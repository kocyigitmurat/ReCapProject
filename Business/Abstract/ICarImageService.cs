using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetCarImagesByCarId(int carId);
        IDataResult<CarImage> GetById(int id);
        IResult Add(CarImage carImage);
        IResult Update(CarImage carImage);
        IResult Delete(CarImage carImage);
    }
}
