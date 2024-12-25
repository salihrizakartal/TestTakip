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
    public class EmplyoeeManager : IEmplyoeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmplyoeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void TDelete(int id)
        {
            _employeeDal.Delete(id);
        }

        public List<Emplyoee> TGetAll()
        {
            return _employeeDal.GetAll();   
        }

        public Emplyoee TGetById(int id)
        {
            return _employeeDal.GetById(id);
        }

        public void TInsert(Emplyoee entity)
        {
            _employeeDal.Insert(entity);
        }

        public void TUpdate(Emplyoee entity)
        {
            _employeeDal.Update(entity);
        }
    }
}
