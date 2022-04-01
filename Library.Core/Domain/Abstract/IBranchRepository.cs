using System;
using System.Collections.Generic;
using System.Text;
using lib_books.Core.Domain.Entities;

namespace lib_books.Core.Domain.Abstract
{
    public interface IBranchRepository
    {
        void Add(Branch branch);
        void Update(Branch branch);
        List<Branch> Get();
        Branch Get(int id);
        void Delete(int id);
    }
}
