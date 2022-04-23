using CallWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Teacher Teacher { get; set; }

        public int TeacherId { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
