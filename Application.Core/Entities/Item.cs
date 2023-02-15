using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Entities
{
    public class Item:EntityBase
    {
        public string ProjectName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
