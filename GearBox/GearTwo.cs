using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GearBoxKata
{
   public class GearTwo:Gear
    {
        private GearBox _gearBox;

        public GearTwo(GearBox _gearBox)
        {
            // TODO: Complete member initialization
            this._gearBox = _gearBox;
        }

        public override void ShiftUp()
        {
            _gearBox.CurrentGear = new GearThree(_gearBox);
        }

        public override void ShiftDown()
        {
            _gearBox.CurrentGear = new GearOne(_gearBox);
        }

        public override string ToString()
        {
            return "2";
        }
    }
}
