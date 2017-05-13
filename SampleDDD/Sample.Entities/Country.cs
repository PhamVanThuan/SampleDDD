using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Core.Entity;

namespace Sample.Entities
{
    [Table("Country")]
    public class Country : Entity<int>
    {
        public virtual IEnumerable<Person> Persons { get; set; }
    }
}
