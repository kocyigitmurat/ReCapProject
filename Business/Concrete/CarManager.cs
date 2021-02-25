using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        int nameLengthMinLimit = 2;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (!validate(car))
            {                
                return new ErrorResult(Messages.controlInfo);
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IResult Update(Car car)
        {
            if(!validate(car))
            {
                return new ErrorResult(Messages.UpdatedError);
            }
            _carDal.Update(car);
            return new SuccessResult(Messages.UpdatedSuccess);
        }

        private bool validate(Car car)
        {
            bool isValid = true;

            if(car.Name.Length < nameLengthMinLimit)
            {
                isValid = false;
            }
            if (car.DailyPrice <= 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
