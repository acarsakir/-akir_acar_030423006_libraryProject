using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace entityLayer.concrete
{
    public class appRole : IdentityRole<int>
    {
        public string Description { get; set; }
    }
}
