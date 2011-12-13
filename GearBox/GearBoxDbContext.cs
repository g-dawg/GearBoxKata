using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace GearBoxKata
{
    public class GearBoxDbContext : DbContext
    {
        
        public IDbSet<GearBox> GearBoxes { get; set; }

    }
}
