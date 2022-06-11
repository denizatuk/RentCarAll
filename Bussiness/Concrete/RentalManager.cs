using Bussiness.Abstract;
using Bussiness.Constans;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }


        //[ValidationAspect(typeof(RentValidator))]

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);
            if (result==null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.SuccessMessage);

            }
            else
            {
                return new ErrorResult(Messages.ReturnRentalError);
            }

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.SuccessMessage);
        }

        [PerformanceAspect(5)]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.SuccessMessage);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.SuccessMessage);
        }
    }
}
