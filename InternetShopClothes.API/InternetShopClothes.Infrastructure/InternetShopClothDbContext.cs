using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopClothes.Infrastructure
{
    public class InternetShopClothDbContext:DbContext
    {
        public InternetShopClothDbContext(DbContextOptions options) : base(options) { }
    }
}
