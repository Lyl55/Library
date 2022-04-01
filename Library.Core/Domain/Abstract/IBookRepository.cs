using System;
using System.Collections.Generic;
using System.Text;
using lib_books.Core.Domain.Entities;

namespace lib_books.Core.Domain.Abstract
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Update(Book book);
        List<Book> Get();
        Book Get(int id);
        void Delete(int id);
    }
}
