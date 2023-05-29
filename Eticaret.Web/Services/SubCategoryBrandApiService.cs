using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using System.Linq.Expressions;

namespace Eticaret.Web.Services
{
    public class SubCategoryBrandApiService
    {

        private readonly HttpClient _httpClient;
        public SubCategoryBrandApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CustomResponseDto<SubCategoryBrand>> AddAsync(SubCategoryBrand entity)
        {
            var response = await _httpClient.PostAsJsonAsync("SubCategoryBrand/Add", entity);

            if (!response.IsSuccessStatusCode)
                return null;

            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<SubCategoryBrand>>();

            return responseBody;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"SubCategoryBrand/Delete/{id}");

            return response.IsSuccessStatusCode;
        }

        public Task<CustomResponseDto<SubCategoryBrand>> GetAsync(Expression<Func<SubCategoryBrand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomResponseDto<List<SubCategoryBrand>>> GetListAsync(Expression<Func<SubCategoryBrand, bool>> filter = null)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<SubCategoryBrand>>>("SubCategoryBrand/GetList");

            return response;
        }

        public async Task<CustomResponseDto<SubCategoryBrand>> GetModelByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<SubCategoryBrand>>($"SubCategoryBrand/GetById/{id}");

            return response;
        }

        public async Task<bool> UpdateAsync(SubCategoryBrand entity)
        {
            var response = await _httpClient.PutAsJsonAsync("SubCategoryBrand/Update", entity);

            return response.IsSuccessStatusCode;
        }
    }
}
