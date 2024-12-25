using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTakip.EntityLayer.Concrete
{
    public class Emplyoee
    {

        [Key]
        public int EmplyoeeId { get; set; }
        public string RegistrationId { get; set; }
        public string Department { get; set; }
        public string EmplyoeeName { get; set; }
        public string Position { get; set; }

    }
}
