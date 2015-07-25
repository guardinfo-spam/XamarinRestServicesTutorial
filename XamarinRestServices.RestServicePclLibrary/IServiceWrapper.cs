using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinRestServices.Models;

namespace XamarinRestServices.RestServicePclLibrary
{
    public interface IServiceWrapper
    {
        Task<string> GetData(string id);
        
        Task<string> RegisterUserJsonRequest(UserModel model);

        Task<string> RegisterUserFormRequest(UserModel model);
    }
}
