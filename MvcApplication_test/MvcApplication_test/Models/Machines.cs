using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication_test.Models
{
    [Table("machines")]
    public class Machines
    {
        public int id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public int status { get; set; }
    }


}