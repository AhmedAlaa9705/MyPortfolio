using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Entities
{
    public class Owner:EntityBase
    {
        public string FullName { get; set; }
        public string AvatarUrl { get; set; }
        public string JobTitle { get; set; }
    }
}
