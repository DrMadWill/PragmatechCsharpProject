using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
