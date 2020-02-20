using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace LaptopClient.Models
{
    public class BookDal
    {
        private const string Base_ADDR = "http://localhost:49972/BookService.svc/";

        public List<Book> GetBooks()
        {
            HttpClient client = new HttpClient();
            var result = client.GetStringAsync(Base_ADDR + "GetBooks");
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(result.Result);
            client.Dispose();
            return books;
        }

        public Book GetBook(string id)
        {
            HttpClient client = new HttpClient();
            var result = client.GetAsync(Base_ADDR + "GetBook/" + id);
            var b = result.Result.Content.ReadAsAsync(typeof(Book)).Result;
            client.Dispose();
            return (Book)b;
        }
        public void Create(Book b)
        {
            HttpClient client = new HttpClient();
            var response = client.PostAsJsonAsync(Base_ADDR + "Create", b).Result;
            var bb = response.Content.ReadAsAsync(typeof(Book)).Result;
            client.Dispose();
        }
        public void Delete(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.DeleteAsync(Base_ADDR +"Detele/"+ id).Result;
            //var bb = response.Content.ReadAsAsync(typeof(Book)).Result;
            client.Dispose();
        }
        public List<Book> SearchBook2s(int Pmin, int Pmax)
        {
            HttpClient client = new HttpClient();
            var response = client.GetStringAsync(Base_ADDR + "SearchBook2s/" + Pmin + "/" + Pmax);
            var bookList = JsonConvert.DeserializeObject<List<Book>>(response.Result);
            client.Dispose();
            return bookList;
        }
    }
}