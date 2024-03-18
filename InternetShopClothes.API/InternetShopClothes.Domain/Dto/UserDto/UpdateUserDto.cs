using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopClothes.Domain.Dto.UserDto
{
    public class UpdateUserDto : BaseUserDto, IUpdateDto
    {
        public int Id { get; set; }
    }
}
