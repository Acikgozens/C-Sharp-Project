using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Concrete
{
    public class EmployeeService : Service<Employee>, IEmployeeService
    {

        private readonly IEmployeeDal _employeeDal;

        public EmployeeService(IEmployeeDal employeeDal, IGenericDal<Employee> genericDal) : base(genericDal)
        {
            _employeeDal = employeeDal;
        }

        //public Task<CustomResponseDto<Employee>> AddAsync(Employee entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<CustomResponseDto<bool>> DeleteByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<CustomResponseDto<Employee>> GetAsync(Expression<Func<Employee, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<CustomResponseDto<List<Employee>>> GetListAsync(Expression<Func<Employee, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<CustomResponseDto<Employee>> GetModelByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<CustomResponseDto<Employee>> UpdateAsync(Employee entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<Employee> AddAsync(Employee employee)
        //{
        //    return await _employeeDal.AddAsync(employee);
        //}

        //public async Task<bool> DeleteByIdAsync(int id)
        //{
        //    return await _employeeDal.DeleteByIdAsync(id);
        //}

        //public async Task<Employee> GetAsync(Expression<Func<Employee, bool>> filter)
        //{
        //    return await _employeeDal.GetAsync(filter);
        //}

        //public async Task<List<Employee>> GetListAsync(Expression<Func<Employee, bool>> filter = null)
        //{
        //    return await _employeeDal.GetListAsync(filter);
        //}


        //public async Task<Employee> UpdateAsync(Employee employee)
        //{
        //    return await _employeeDal.UpdateAsync(employee);
        //}

        //public async Task<Employee> GetByIdAsync(int id)
        //{
        //    return await _employeeDal.GetModelByIdAsync(id);
        //}
    }
}
