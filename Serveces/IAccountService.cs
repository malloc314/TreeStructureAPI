using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Models;

namespace TreeStructure.Serveces
{
    public interface IAccountService
    {
        public void RegisterUser(RegisterUserDto dto);
        //public string GenerateJwt(LoginDto dto);
    }
}
