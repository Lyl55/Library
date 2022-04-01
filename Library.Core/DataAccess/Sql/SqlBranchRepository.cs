using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Text;
using lib_books.Core.Domain.Abstract;
using lib_books.Core.Domain.Entities;

namespace lib_books.Core.DataAccess.Sql
{
    public class SqlBranchRepository:IBranchRepository
    {
        private readonly string _connectionstring;

        public SqlBranchRepository(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        public void Add(Branch branch)
        {
            using (var con=new SqlConnection(_connectionstring))
            {
                con.Open();
                string query = "Insert into Branches_libr output inserted.id values(@Name,@Address) ";
                var cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("Name", branch.Name);
                cmd.Parameters.AddWithValue("Address", branch.Address);
                branch.Id= Convert.ToInt32(cmd.ExecuteScalar());
                //cmd.ExecuteNonQuery();
            }
        }

        public void Update(Branch branch)
        {
            using (var con=new SqlConnection(_connectionstring))
            {
                con.Open();
                string query = "update Branches_libr set Name=@Name,Address=@Address where Id=@Id";
                var cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("Id", branch.Id);
                cmd.Parameters.AddWithValue("Name", branch.Name);
                cmd.Parameters.AddWithValue("Address", branch.Address);
                cmd.ExecuteNonQuery();
            }
        }
        public List<Branch> Get()
        {
            using (var con=new SqlConnection(_connectionstring))
            {
               con.Open();
               string query = "select * from Branches_libr";
               var cmd = new SqlCommand(query, con);
               var reader = cmd.ExecuteReader();
               List<Branch>branches = new List<Branch>();
               while (reader.Read())
               {
                   Branch branch = ReaderDb(reader);
                   branches.Add(branch);
               }

               return branches;
            }
        }

        public Branch Get(int id)
        {
            using (SqlConnection con=new SqlConnection(_connectionstring))
            {
                con.Open();
                string query = @"select * from Branches_libr where Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("Id", id);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var entity = ReaderDb(reader);
                    return entity;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Delete(int id)
        {
            using (var con=new SqlConnection(_connectionstring))
            {
               con.Open();
               string query = "delete from Branches_libr where Id=@Id";
               var cmd = new SqlCommand(query, con);
               cmd.Parameters.AddWithValue("Id", id);
               cmd.ExecuteNonQuery();
            }
        }
        private Branch ReaderDb(SqlDataReader reader)
        {
            return new Branch
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                Address =reader["address"].ToString()
            };

        }
    }
}
