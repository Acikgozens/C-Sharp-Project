using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Web.Services;
using ETicaret.BussinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Eticaret.Web.Controllers
{
    public class SubCategoryBrandController : Controller
    {
        private readonly SubCategoryBrandApiService _subCategoryBrandApiService;


        //     private readonly ISubCategoryBrandService _SubCategoryBrandService;

        public SubCategoryBrandController(SubCategoryBrandApiService subCategoryBrandApiService)
        {
            _subCategoryBrandApiService = subCategoryBrandApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            CustomResponseDto<List<SubCategoryBrand>> customResponseDto = await _subCategoryBrandApiService.GetListAsync();
            return View(customResponseDto.Data);
        }


        public async Task<IActionResult> Delete(int id)
        {
            bool sonuc = await _subCategoryBrandApiService.DeleteByIdAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Add()
        {
            SubCategoryBrand subCategoryBrand = new SubCategoryBrand();

            return View(subCategoryBrand);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SubCategoryBrand addSubCategoryBrand)
        {
            addSubCategoryBrand.SubCategoryBrandStatus = true;

            if (ModelState.IsValid)
            {

                var sonuc = await _subCategoryBrandApiService.AddAsync(addSubCategoryBrand);
                if (sonuc.StatusCode == 200)
                {
                    return RedirectToAction(nameof(Index));
                }

            }

            return View(addSubCategoryBrand);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var sonuc = await _subCategoryBrandApiService.GetModelByIdAsync(id);
            //List<bool> bools = new List<bool>() { true, false };
            //ViewBag.Status = new SelectList(bools,)

            return View(sonuc.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SubCategoryBrand updateSubCategoryBrand)
        {
            var sonuc = await _subCategoryBrandApiService.UpdateAsync(updateSubCategoryBrand);
            return RedirectToAction(nameof(Index));
        }
    }
}
