using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    public class SubCategoryBrandController : CustomBaseController
    {

        private readonly ISubCategoryBrandService _ISubCategoryBrandService;

        public SubCategoryBrandController(ISubCategoryBrandService ISubCategoryBrandService)
        {
            _ISubCategoryBrandService = ISubCategoryBrandService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            //var result = await _ICategoryService.GetListAsync(x => x.CategoryStatus == true); // CustomerResponseData<T>
            //if (result is not null)
            //    return Ok(result);
            return CreateActionResult(await _ISubCategoryBrandService.GetListAsync(x => x.SubCategoryBrandStatus == true));
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _ISubCategoryBrandService.GetModelByIdAsync(id));

        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] SubCategoryBrand subCategoryBrand)
        {
            return CreateActionResult(await _ISubCategoryBrandService.AddAsync(subCategoryBrand));
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]

        public async Task<IActionResult> Delete(int id)
        {
            return CreateActionResult(await _ISubCategoryBrandService.DeleteByIdAsync(id));
        }

        [HttpPut]
        [Route("[action]")]

        public async Task<IActionResult> Update([FromBody] SubCategoryBrand subCategoryBrand)
        {
            return CreateActionResult(await _ISubCategoryBrandService.UpdateAsync(subCategoryBrand));
        }

    }
}
