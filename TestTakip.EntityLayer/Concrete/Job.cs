using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTakip.EntityLayer.Concrete
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public string PowerPlantName { get; set; }
        public string City { get; set; }
        public DateTime JobDate { get; set; }
        public string TestName { get; set; }
        public string EmplyoeeName { get; set; }
        public string Description { get; set; }
    }
}
