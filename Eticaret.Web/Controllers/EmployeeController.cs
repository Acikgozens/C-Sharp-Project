using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeApiService _employeeService;
        public EmployeeController(EmployeeApiService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var sonuc = await _employeeService.GetListAsync();

            return View(sonuc.Data);
        }


        public async Task<IActionResult> Delete(int id)
        {
           var sonuc = await _employeeService.DeleteByIdAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View(new Employee());
        }

        [HttpPost]
        public async Task<IActionResult> Add(Employee addEmployee)
        {
            addEmployee.EmployeeStatu = true;

            if (ModelState.IsValid)
            {

                var sonuc = await _employeeService.AddAsync(addEmployee);
                if (sonuc.StatusCode == 200)
                {
                    return RedirectToAction(nameof(Index));
                }

            }

            return View(addEmployee);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var sonuc = await _employeeService.GetModelByIdAsync(id);
            //List<bool> bools = new List<bool>() { true, false };
            //ViewBag.Status = new SelectList(bools,)

            return View(sonuc.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Employee updateEmployee)
        {
            var sonuc = await _employeeService.UpdateAsync(updateEmployee);
            return RedirectToAction(nameof(Index));
        }

    }



}

