using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTakip.DataAccessLayer.Abstract;
using TestTakip.DataAccessLayer.Context;
using TestTakip.DataAccessLayer.Repositories;
using TestTakip.EntityLayer.Concrete;

namespace TestTakip.DataAccessLayer.EntityFramework
{
    public class EfJobDal : GenericRepository<Job>, IJobDal
    {
        public EfJobDal(TestContext context) : base(context)
        {
        }
    }
}
