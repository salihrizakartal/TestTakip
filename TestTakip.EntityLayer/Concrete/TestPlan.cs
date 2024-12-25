using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTakip.EntityLayer.Concrete
{
    public class TestPlan
    {
        [Key]
        public int TestId { get; set; }
        public string TestName { get; set; }
        public string PowerPlantName { get; set; }
        public DateTime TestDate { get; set; }
    }
}
