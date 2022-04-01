using System;
using System.Collections.Generic;
using System.Text;
using lib_books.Core.Domain.Abstract;

namespace lib_books.Core.DataAccess.Sql
{
    public class SqlUnitOfWork:IUnitOfWork
    {
        private readonly string _connectionstring;

        public SqlUnitOfWork(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        //1
        /*public IBranchRepository BranchRepository
        {
            get
            {

                return new SqlBranchRepository(_connectionstring);
            }
        }*/

        //2
        public IBranchRepository BranchRepository => new SqlBranchRepository(_connectionstring);

        public IBookRepository BookRepository => new SqlBookRepository(_connectionstring);

        public IAuthorRepository AuthorRepository => new SqlAuthorRepository(_connectionstring);

    }
}
