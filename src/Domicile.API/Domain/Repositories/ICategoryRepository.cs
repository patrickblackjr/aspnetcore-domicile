
using System.Collections.Generic;
using System.Threading.Tasks;
using Domicile.API.Domain.Models;
using Domicile.API.Domain.Repositories;
using Domicile.API.Domain.Services;

namespace Domicile.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}