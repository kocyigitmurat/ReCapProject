using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        public IResult Add(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetCarImagesByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImage carImage)
        {
            throw new NotImplementedException();
        }
    }
}
