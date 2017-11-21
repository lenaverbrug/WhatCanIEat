using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspIdentityServer.data.Models.PostModels
{
    public class CreateUserModel
    {
        public string password1 { get; set; }
        public string password2 { get; set; }
        public string username { get; set; }
        public string lievelingsKeleur { get; set; }
    }
}
