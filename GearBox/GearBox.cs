using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GearBoxKata
{
    public class GearBox
    {
        public Guid Id { get; set; }

        public GearBox()
        {
            //Id = Guid.NewGuid();
            CurrentGear = new Neutral(this);
        }

        public Gear CurrentGear { get; set; }

        public void ShiftUp()
        {
            CurrentGear.ShiftUp(); 
        }

        public void ShiftDown()
        {
            CurrentGear.ShiftDown();
        }
    }
}
