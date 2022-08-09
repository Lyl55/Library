using System;
using System.Collections.Generic;
using System.Text;
using lib_books.Core.Domain.Abstract;

namespace lib_books.Core
{
    public class Kernel
    {
        public static IUnitOfWork DB { get; set;}
    }
}
