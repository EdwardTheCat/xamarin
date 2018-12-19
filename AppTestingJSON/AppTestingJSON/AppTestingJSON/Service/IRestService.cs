using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppTestingJSON.Model;

namespace AppTestingJSON.Service
{
    public interface IRestService
    {
       Task<Book> RefreshDataAsync();
    }
}
