using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IResult Add(Employee employee)
        {
            _employeeDal.Add(employee);
            return new SuccessResult(message: "Yeni Çalışan Eklendi");
        }

        public IResult  Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult(message: "Çalışan İşten Çıkarıldı");
        }

        public IDataResult<Employee> GetById(int employeeId)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(p => p.Id == employeeId));
        }

        public IDataResult<List<Employee>> GetList()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetList().ToList());
        }

        public IDataResult<List<Employee>>  GetListByCity(int cityId)
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetList(p=>p.City==cityId).ToList());
        }

        public IResult  Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult(message: "Çalışan bilgileri Güncellendi");
        }
    }
}
