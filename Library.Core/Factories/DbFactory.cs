using System;
using System.Collections.Generic;
using System.Text;
using lib_books.Core.DataAccess.Sql;
using lib_books.Core.Domain.Abstract;

namespace lib_books.Core.Factories
{
    public class DbFactory
    {
        public static IUnitOfWork GetDb(DbSettings settings)
        {
            switch (settings.DbType)
            {
                case "sql":
                    return new SqlUnitOfWork(settings.ConnectionString);
                default:
                    return new SqlUnitOfWork(settings.ConnectionString);
            }
        }
    }
}
