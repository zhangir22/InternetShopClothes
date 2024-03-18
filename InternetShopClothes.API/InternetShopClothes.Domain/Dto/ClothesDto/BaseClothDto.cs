using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopClothes.Domain.Dto.ClothesDto
{
    public class BaseClothDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public string? Textile { get; set; }
        public string? TextileColor { get; set; }
        public int? GenderCloth { get; set; }
        public int? TypeCloth { get; set; }
    }
}
