using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemoteLaptopServices
{
    public class BookDal
    {
        DemoEntities db = new DemoEntities();
        public BookDal()
        {

        }
        public List<BookContract> GetBooks()
        {
            return db.tbLaptops.Select(b => new BookContract
            {
                LaptopCode = b.LaptopCode,
                LaptopName = b.LaptopName,
                Price = b.Price,
                FingerPrint = b.FingerPrint
            }).ToList();
        }
        public BookContract GetBook(int id)
        {
            tbLaptop cur = db.tbLaptops.SingleOrDefault(b => b.LaptopCode == id);
            if (cur != null)
            {
                return new BookContract
                {
                    LaptopCode = cur.LaptopCode,
                    LaptopName = cur.LaptopName,
                    Price = cur.Price,
                    FingerPrint = cur.FingerPrint
                };
            }
            return null;
        }
        public List<BookContract> SearchBook2s(string Pmin, string Pmax)
        {
            var Pmin1 = Convert.ToInt32(Pmin);
            var Pmax1 = Convert.ToInt32(Pmax);
            //coverttu List<Book> sang List<BookModel>
            return db.tbLaptops.Where(b => b.Price >= Pmin1 && b.Price <= Pmax1).Select(b => new BookContract
            {
                LaptopCode = b.LaptopCode,
                LaptopName = b.LaptopName,
                Price = b.Price,
                FingerPrint = b.FingerPrint
            }).ToList();
        }
        public void Create(BookContract book)
        {
            tbLaptop cur = db.tbLaptops.SingleOrDefault(b => b.LaptopCode == book.LaptopCode);
            if (cur == null)
            {
                tbLaptop item = new tbLaptop { LaptopCode = book.LaptopCode, LaptopName = book.LaptopName, Price = book.Price, FingerPrint = book.FingerPrint };
                db.tbLaptops.Add(item);
                db.SaveChanges();
            }
        }
        public void Delete(string id)
        {
            var idd = Convert.ToInt32(id);
            tbLaptop cur = db.tbLaptops.SingleOrDefault(b => b.LaptopCode == idd);
            if (cur != null)
            {
                db.tbLaptops.Remove(cur);
                db.SaveChanges();
            }
        }
    }
}