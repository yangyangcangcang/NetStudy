using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WuQiang.WepApi.WebApp.Models;
using WuQiang.WepApi.WebApp.Unity.Interface;

namespace WuQiang.WepApi.WebApp.Unity.Service
{
    public class UserService : IUserService
    {
        private DbContext _DbContext = null;
        public UserService(DbContext dbContext)
        {
            this._DbContext = dbContext;
        }

        public List<UserModel> GetList()
        {
            return new List<UserModel>() {
                new UserModel() { Id = 1, Name = "zhangsn", Age = 12, Sex = 1, Description = "上海人" },
                new UserModel() { Id = 2, Name = "zhangsn2", Age = 13, Sex = 2, Description = "北京人" },
                new UserModel() { Id = 3, Name = "zhangsn3", Age = 14, Sex = 1, Description = "重庆人" }
            };
        }
    }
}