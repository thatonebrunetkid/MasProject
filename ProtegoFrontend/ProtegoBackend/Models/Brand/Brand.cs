using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegoBackend.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }

        public static List<Brand> Brands = new List<Brand>();
        public List<Model.Model> Models = new List<Model.Model>();

        public Brand(int BrandId, string Name)
        {
            this.BrandId = BrandId;
            this.Name = Name;
        }

        public override string ToString()
        {
            return $"Brand Name: {Name}";
        }
    }
}
