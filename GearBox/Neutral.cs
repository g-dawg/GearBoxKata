using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GearBoxKata
{
    public class Neutral : Gear
    {
        private GearBox _gearBox;

        public Neutral()
            : base()
        {
        }

        public Neutral(GearBox gearBox)
            : base(gearBox)
        {
            _gearBox = gearBox;
        }

        public override void ShiftUp()
        {
            _gearBox.CurrentGear = new GearOne(_gearBox);
        }

        public override void ShiftDown()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "N";
        }
    }

    public class Gear : IGear
    {
        private GearBox _gearBox;

        public Gear()
        {

        }

        public Gear(GearBox gearBox)
        {
            _gearBox = gearBox;
        }

        public virtual void ShiftUp() { }

        public virtual void ShiftDown() { }

    }

}
