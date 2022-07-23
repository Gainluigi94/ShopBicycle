using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Request.User
{
    public class GetAllUser
    {
        public string Email { get; set; } = null!;
        public string? Password
        {
            get; set;
        }
    }
}
