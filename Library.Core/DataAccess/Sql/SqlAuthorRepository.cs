using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using lib_books.Core.Domain.Abstract;
using lib_books.Core.Domain.Entities;

namespace lib_books.Core.DataAccess.Sql
{
    public class SqlAuthorRepository:IAuthorRepository
    {
        private readonly string _connect;

        public SqlAuthorRepository(string connect)
        {
            _connect = connect;
        }
        public void Add(Author author)
        {
            using (var con = new SqlConnection(_connect))
            {
                con.Open();
                string query = "Insert into Authors_libr output inserted.id values(@Name,@Surname)";
                var command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("name", author.Name);
                command.Parameters.AddWithValue("surname", author.Surname);
                author.Id = Convert.ToInt32(command.ExecuteScalar());
            }
        }

        

        public List<Author> Get()
        {
            using (var con = new SqlConnection(_connect))
            {
                con.Open();
                string query = "select * from Authors_libr";
                var command = new SqlCommand(query, con);
                var reader = command.ExecuteReader();
                var list = new List<Author>();
                while (reader.Read())
                {
                    var author = Reader(reader);
                    list.Add(author);
                }

                return list;
            }
        }
        public void Update(Author author)
        {
            using (var con = new SqlConnection(_connect))
            {
                con.Open();
                string query =
                    "update Authors_libr set Name=@name,Surname=@surname where Id=@id";
                var command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("id", author.Id);
                command.Parameters.AddWithValue("name", author.Name);
                command.Parameters.AddWithValue("surname", author.Surname);
                command.ExecuteReader();
            }
        }

        public Author Get(int id)
        {
            using (var con = new SqlConnection(_connect))
            {
                con.Open();
                string query = "Select * from Authors_libr where Id=@id";
                var command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("id", id);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var author = Reader(reader);
                    return author;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Delete(int id)
        {
            using (var con = new SqlConnection(_connect))
            {
                con.Open();
                string query = "delete from Authors_libr where Id=@id";
                var command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("Id", id);
                command.ExecuteNonQuery();
            }
        }
        private Author Reader(SqlDataReader reader)
        {
            return new Author
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString(),
                Surname = reader["Surname"].ToString(),
            };
        }
    }
}
