using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_razor_layout.Models
{
    public class Pizza
    {
        public int Id { get; set; }


        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public string Image { get; set; }

        public double Price { get; set; }

        public Pizza()
        {

        }

        public Pizza(string name, string description, string image, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.Price = price;

        }
    }
}
