using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WuQiang.WepApi.WebApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public int Sex { get; set; }
    }
}