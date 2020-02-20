using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RemoteLaptopServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookService.svc or BookService.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {
        BookDal dal = new BookDal();
        public void Create(BookContract b)
        {
            dal.Create(b);
        }

        public void Delete(string id)
        {
            dal.Delete(id);
        }

       

        public BookContract GetBook(string id)
        {
            return dal.GetBook(Convert.ToInt32(id));
        }

        public List<BookContract> GetBooks()
        {
            return dal.GetBooks();
        }

        public List<BookContract> SearchBook2s(string Pmin, string Pmax)
        {
            return dal.SearchBook2s(Pmin, Pmax);
        }
    }
}
