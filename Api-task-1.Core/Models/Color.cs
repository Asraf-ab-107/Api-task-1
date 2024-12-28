using Api_task_1.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_task_1.Core.Models
{
    public class Color:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> products { get; set; }

    }
}
