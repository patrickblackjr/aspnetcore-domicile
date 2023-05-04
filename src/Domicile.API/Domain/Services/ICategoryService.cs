using System.Collections.Generic;
using System.Threading.Tasks;
using Domicile.API.Domain.Models;

namespace Domicile.API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}