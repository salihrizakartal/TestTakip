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
    public class JobManager : IJobService
    {
        private readonly IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public void TDelete(int id)
        {
           _jobDal.Delete(id);
        }

        public List<Job> TGetAll()
        {
            return _jobDal.GetAll();    
        }

        public Job TGetById(int id)
        {
           return _jobDal.GetById(id);
        }

        public void TInsert(Job entity)
        {
            _jobDal.Insert(entity);
        }

        public void TUpdate(Job entity)
        {
            _jobDal.Update(entity);
        }
    }
}
