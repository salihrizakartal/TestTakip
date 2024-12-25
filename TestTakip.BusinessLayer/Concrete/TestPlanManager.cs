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
    public class TestPlanManager : ITestPlanService
    {
        private readonly ITestPlanDal _testPlanDal;

        public TestPlanManager(ITestPlanDal testPlanDal)
        {
            _testPlanDal = testPlanDal;
        }

        public void TDelete(int id)
        {
            _testPlanDal.Delete(id);
        }

        public List<TestPlan> TGetAll()
        {
            return _testPlanDal.GetAll();
        }

        public TestPlan TGetById(int id)
        {
            return _testPlanDal.GetById(id);
        }

        public void TInsert(TestPlan entity)
        {
            _testPlanDal.Insert(entity);
        }

        public void TUpdate(TestPlan entity)
        {
            _testPlanDal.Update(entity);
        }
    }
}
