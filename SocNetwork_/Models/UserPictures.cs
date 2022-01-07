using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Models
{
    public class UserPictures
    {
        public int id { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string Picture { get; set; }
        public string textForPicture { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime dateTimePost { get; set; }
    }
}
