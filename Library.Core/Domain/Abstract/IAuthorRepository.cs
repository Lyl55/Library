using System;
using System.Collections.Generic;
using System.Text;
using lib_books.Core.Domain.Entities;

namespace lib_books.Core.Domain.Abstract
{
    public interface IAuthorRepository
    {
        void Add(Author book);
        void Update(Author book);
        List<Author> Get();
        Author Get(int id);
        void Delete(int id);
    }
}
