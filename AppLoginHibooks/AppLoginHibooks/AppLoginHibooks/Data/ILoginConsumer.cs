using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppLoginHibooks.Model;

namespace AppLoginHibooks.Data
{
    public interface ILoginConsumer
    {
        Task<int> loginAsync(Login login);

        Task<int> logoutAsync();
    }
}
