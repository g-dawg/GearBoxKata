using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GearBoxKata
{
    class GearThree:Gear
    {
        private GearBox _gearBox;

        public GearThree(GearBox _gearBox)
        {
            // TODO: Complete member initialization
            this._gearBox = _gearBox;
        }

        public override void ShiftUp()
        {
        }

        public override void ShiftDown()
        {
            _gearBox.CurrentGear = new GearTwo(_gearBox);
        }

        public override string ToString()
        {
            return "3";
        }
    }
}
