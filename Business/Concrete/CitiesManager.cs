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
    public class CitiesManager : ICitiesService
    {
        ICitiesDal _citiesDal;
        public CitiesManager(ICitiesDal citiesDal)
        {
            _citiesDal = citiesDal;
        }
        

        public IDataResult<List<Cities>>  GetList()
        {
            return new SuccessDataResult<List<Cities>>(_citiesDal.GetList().ToList());
        }
    }
}
