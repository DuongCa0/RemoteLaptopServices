using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Services;

namespace RemoteLaptopServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookService" in both code and config file together.
    [ServiceContract]
    public interface IBookService
    {
        [WebGet(UriTemplate = "GetBooks", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<BookContract> GetBooks();
        [OperationContract]
        [WebGet(UriTemplate = "GetBook/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        BookContract GetBook(string id);
       
        
        [OperationContract]
        [WebGet(UriTemplate = "SearchBook2s/{Pmin}/{Pmax}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<BookContract> SearchBook2s(string Pmin, string Pmax);
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Create", RequestFormat = WebMessageFormat.Json)]
        void Create(BookContract b);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Detele/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        void Delete(string id);

    }
}
