using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreProject.Models
{
    public interface IBookstoreRepository
    {
        //Replaces List, setup specifically to query data, can read but not write to data
        IQueryable<Book> Books { get; }
    }
}
