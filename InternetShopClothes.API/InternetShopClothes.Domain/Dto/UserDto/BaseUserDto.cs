using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopClothes.Domain.Dto.UserDto
{
    public class BaseUserDto:IBaseDto
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } 

    }
}
