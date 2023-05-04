using System.Collections.Generic;

namespace Domicile.API.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}