using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<Employee> GetById(int employeeId);

        IDataResult<List<Employee>> GetList();
        IDataResult<List<Employee>> GetListByCity(int cityId);
        IResult Add(Employee employee);
        IResult Delete(Employee employee);
        IResult Update(Employee employee);


    }
}
