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
    public class EfEmplyoeeDal : GenericRepository<Emplyoee>, IEmployeeDal
    {
        public EfEmplyoeeDal(TestContext context) : base(context)
        {
        }
    }
}
