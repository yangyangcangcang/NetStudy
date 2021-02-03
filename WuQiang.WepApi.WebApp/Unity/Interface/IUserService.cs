using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WuQiang.WepApi.WebApp.Models;

namespace WuQiang.WepApi.WebApp.Unity.Interface
{
    public interface IUserService
    {
        List<UserModel> GetList();
    }
}
