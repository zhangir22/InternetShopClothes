using InternetShopClothes.Domain.Dto.ClothesDto.EnumCloth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopClothes.Domain.Helpers
{
    public class ClothTypeHelper
    {
        public static string GetClothType(ClothTypeEnum type)
        {
            switch (type)
            {
                case ClothTypeEnum.Casual:
                    return "Повседневный";
                case ClothTypeEnum.Sport:
                    return "Спортивный";
                case ClothTypeEnum.Classic:
                    return "Классический";
                case ClothTypeEnum.Work:
                    return "Рабочая одежда";
                default:
                    return string.Empty;
            }
        }
        public static string GetGenderCloth(ClothGenderEnum gender) 
        {
            switch(gender)
            {
                case ClothGenderEnum.Male:
                    return "Мужчина";
                case ClothGenderEnum.Female:
                    return "Женщина";
                default:
                    return string.Empty;
            }
        }
    }
}
