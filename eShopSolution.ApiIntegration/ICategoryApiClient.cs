using eShopSolution.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<bool> CreateProduct(CategoryCreateRequest request);

        Task<bool> UpdateProduct(CategoryUpdateRequest request);

        Task<CategoryVm> GetById(int id, string languageId);

        Task<bool> DeleteProduct(int id);

        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);
    }
}
