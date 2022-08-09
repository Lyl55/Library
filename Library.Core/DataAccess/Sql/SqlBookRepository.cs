using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using lib_books.Core.Domain.Abstract;
using lib_books.Core.Domain.Entities;

namespace lib_books.Core.DataAccess.Sql
{
    public class SqlBookRepository : IBookRepository
    {
        private readonly string _connectionstring;

        public SqlBookRepository(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public void Add(Book book)
        {
            using (var con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string query = "Insert into Books_libr output inserted.id values(@Name,@Language,@IsTranslation,@Genre)";
                var command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("name", book.Name);
                command.Parameters.AddWithValue("language", book.Language);
                command.Parameters.AddWithValue("istranslation", book.IsTranslation);
                command.Parameters.AddWithValue("genre", book.Genre);
                book.Id = Convert.ToInt32(command.ExecuteScalar()); //bazada yaranan id-ni goturur
                command.ExecuteNonQuery();
            }
        }

        public void Update(Book book)
        {
            using (var con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string query =
                    "update Books_libr set Name=@name,Language=@language,IsTranslation=@istranslation,Genre=@genre where Id=@id";
                var command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("id", book.Id);
                command.Parameters.AddWithValue("name", book.Name);
                command.Parameters.AddWithValue("language", book.Language);
                command.Parameters.AddWithValue("istranslation", book.IsTranslation);
                command.Parameters.AddWithValue("genre", book.Genre);
                command.ExecuteReader();

            }
        }

        public List<Book> Get()
        {
            using (var con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string query = "select * from Books_libr";
                var command = new SqlCommand(query, con);
                var reader = command.ExecuteReader();
                var list = new List<Book>();
                while (reader.Read())
                {
                    var book = Reader(reader);
                    list.Add(book);
                }

                return list;
            }
        }

        public Book Get(int id)
        {
            
            using (var con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string query = "Select * from Books_libr where Id=@id";
                var command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("id", id);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var book = Reader(reader);
                    return book;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Delete(int id)
        {
            using (var con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string query = "delete from Books_libr where Id=@id";
                var command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("Id", id);
                command.ExecuteNonQuery();
            }
        }

        private Book Reader(SqlDataReader reader)
        {
            return new Book
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString(),
                Language = reader["Language"].ToString(),
                IsTranslation = Convert.ToBoolean(reader["IsTranslation"]),
                Genre = reader["Genre"].ToString()
            };
        }
    }
}

