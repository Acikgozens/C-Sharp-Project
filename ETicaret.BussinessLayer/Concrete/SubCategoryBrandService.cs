using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Repositories;
using ETicaret.BussinessLayer.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eticaret.BussinessLayer.Concrete
{
    public class SubCategoryBrandService : Service<SubCategoryBrand>, ISubCategoryBrandService
    {
        private readonly ISubCategoryBrandDal _subcategorybrandDal;

        public SubCategoryBrandService(ISubCategoryBrandDal subcategorybrandDal, IGenericDal<SubCategoryBrand> genericDal) : base(genericDal)
        {
            _subcategorybrandDal = subcategorybrandDal;
        }

        public Task<CustomResponseDto<List<SubCategoryBrand>>> GetSubCategoriesBrandAsync()
        {
            throw new System.NotImplementedException();
        }



        //public async Task<SubCategoryBrand> AddAsync(SubCategoryBrand SubCategoryBrand)
        //{
        //    return await _subcategorybrandDal.AddAsync(SubCategoryBrand);
        //}

        //public async Task<bool> DeleteByIdAsync(int id)
        //{
        //    return await _subcategorybrandDal.DeleteByIdAsync(id);
        //}

        //public async Task<SubCategoryBrand> GetAsync(Expression<Func<SubCategoryBrand, bool>> filter)
        //{
        //    return await _subcategorybrandDal.GetAsync(filter);
        //}

        //public async Task<List<SubCategoryBrand>> GetListAsync(Expression<Func<SubCategoryBrand, bool>> filter = null)
        //{
        //    return await _subcategorybrandDal.GetListAsync(filter);
        //}

        //public Task<SubCategoryBrand> GetModelByIdAsync(int id)
        //{
        //    return _subcategorybrandDal.GetModelByIdAsync(id);
        //}

        //public async Task<SubCategoryBrand> UpdateAsync(SubCategoryBrand SubCategoryBrand)
        //{
        //    return await _subcategorybrandDal.UpdateAsync(SubCategoryBrand);
        //}
    }
}
