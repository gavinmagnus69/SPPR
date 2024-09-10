using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_253502_AKHMETOV.Domain.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public string Image { get; set; }

        public string ImageExtension { get; set; } 

        public int Calories { get; set; }
    }
}
