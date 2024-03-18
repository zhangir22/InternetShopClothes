using InternetShopClothes.Domain.Dto.Busket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopClothes.Domain.Dto.UserDto
{
    public class GetUserDto : BaseUserDto, IGetDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Balance { get; set; }
        public BusketCloth busket { get; set; }
        
    }
}
