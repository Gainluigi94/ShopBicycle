using Service.Request.User;
using Service.Response.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface IUserrService 
    {

        public UserResponse AddUser(AddUser add);
public UserResponse RemoveUser (RemoveUser remove);
        public UserResponse GetUser(GetUser user);        
        public List<UserResponse> GetUsers();





    }
}
