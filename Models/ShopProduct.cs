using System;
using System.Collections.Generic;

namespace MVC_Projects.Models
{
    public class ShopProduct
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ImagesProducts> Images { get; set; }
    }
}
