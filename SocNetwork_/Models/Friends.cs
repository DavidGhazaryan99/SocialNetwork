using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Models
{
    public class Friends
    {
        public int id { get; set; }
        public string userId { get; set; }
        public string friendUserId { get; set; }
        public ApplicationUser user { get; set; }
        public ApplicationUser friendUser { get; set; }
    }
}
