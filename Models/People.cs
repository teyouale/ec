using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ec.Models
{
    public class People
    {
        [Key]
        public int People_Id { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }

        [ForeignKey("Movie")]
        public int Movie_Id { get; set; }

        public virtual Movie movie { get; set; }


    }
}
