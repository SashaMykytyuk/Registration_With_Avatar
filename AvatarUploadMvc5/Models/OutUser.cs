using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvatarUploadMvc5.Models
{
    public class OutUser
    {
        public string Email{set;get;}
        public string Role { set; get; }
        public string ImgPath { set; get; }
    }
}