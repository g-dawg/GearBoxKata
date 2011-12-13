using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GearBoxKata
{
    class GearOne : Gear
    {
        private GearBox _gearBox;

        public GearOne(GearBox _gearBox)
        {
            // TODO: Complete member initialization
            this._gearBox = _gearBox;
        }

        public override void ShiftUp()
        {
            _gearBox.CurrentGear = new GearTwo(_gearBox);
        }

        public override void ShiftDown()
        {
            _gearBox.CurrentGear = new Neutral(_gearBox);
        }

        public override string ToString()
        {
            return "1";
        }
    }
}
