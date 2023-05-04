using System.Collections.Generic;

namespace Domicile.API.Domain.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PrepTime { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}