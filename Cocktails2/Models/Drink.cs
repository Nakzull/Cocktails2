using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails2.Models
{
    public class Drink
    {
        [Key]
        public int Id { get; private init; }
        public string Name { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
