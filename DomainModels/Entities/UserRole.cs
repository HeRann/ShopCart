using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels.Entities
{
    public class UserRole
    {
        [ForeignKey("User")]
        public int userId { get; set; }

        [ForeignKey("Role")]
        public int roleId { get; set; }
    }
}
