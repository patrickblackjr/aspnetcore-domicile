using System.Collections.Generic;
using System.Threading.Tasks;
using Domicile.API.Domain.Models;
using Domicile.API.Domain.Services;

namespace Domicile.API.Services
{
    public class CategoryService : ICategoryService
    {
        public async Task<IEnumerable<Category>> ListAsync() { }
    }
}