using HomeWork1.Entities;
using System.Collections.Generic;

namespace HomeWork1.Models
{
    public class FoodsViewModel
    {

        public List<Drink> Drinks { get; set; }
        public List<Hotmeal> Hotmeals { get; set; }
        public List<Fastfood> Fastfoods { get; set; }

    }
}
