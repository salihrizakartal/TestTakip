using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTakip.BusinessLayer.Abstract;
using TestTakip.DataAccessLayer.Abstract;
using TestTakip.EntityLayer.Concrete;

namespace TestTakip.BusinessLayer.Concrete
{
    public class PlantManager : IPlantService
    {
        private readonly IPlantDal _plantDal;

        public PlantManager(IPlantDal plantDal)
        {
            _plantDal = plantDal;
        }

        public void TDelete(int id)
        {
           _plantDal.Delete(id);
        }

        public List<Plant> TGetAll()
        {
            return _plantDal.GetAll();
        }

        public Plant TGetById(int id)
        {
           return _plantDal.GetById(id);
        }

        public void TInsert(Plant entity)
        {
            _plantDal.Insert(entity);   
        }

        public void TUpdate(Plant entity)
        {
            _plantDal.Update(entity);
        }
    }
}
