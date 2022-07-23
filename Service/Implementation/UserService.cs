using AutoMapper;
using Model.Classes;
using Repository.IRepository;
using Service.Contract;
using Service.Request.User;
using Service.Response.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class UserService : IUserrService
    {
        IMapper _mapper;
        IUserRepository _userRepository;

        public UserService (IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }   

        public UserResponse AddUser(AddUser add)
        {
            var user = _mapper.Map<Userr>(add);
            _userRepository.Add(user);
            return _mapper.Map<UserResponse>(user);
        }

        public UserResponse GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserResponse> GetUsers()
        {
            throw new NotImplementedException();
        }

        public UserResponse RemoveUser(RemoveUser remove)
        {
            var user = _mapper.Map<Userr>(remove);
            _userRepository.Delete(user);
            return _mapper.Map<UserResponse>(user);
        }
    }
}
