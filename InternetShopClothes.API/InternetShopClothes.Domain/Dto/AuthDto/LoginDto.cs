using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopClothes.Domain.Dto.AuthDto
{
    public class LoginDto:IBaseDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
