using System;
using System.Collections.Generic;
using System.Text;

namespace lib_books.Core.Domain.Abstract
{
    public interface IUnitOfWork
    {
        IBranchRepository BranchRepository { get; }
        IBookRepository BookRepository { get; }
        IAuthorRepository AuthorRepository {get; }
    }
}
