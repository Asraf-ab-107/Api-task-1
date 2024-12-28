using Api_task_1.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_task_1.Core.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Tag Tag { get; set; }
        public ICollection<Color> Color { get; set; }

    }
}
