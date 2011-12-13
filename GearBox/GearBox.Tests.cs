using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GearBoxKata
{
    public class GearBoxTests
    {
        [Fact]
        public void Ska_kunna_skapa_en_växellåda_i_läge_neutral()
        {
            var gearBox = new GearBox();

            Assert.IsType(typeof(Neutral), gearBox.CurrentGear);
            Assert.Equal("N", gearBox.CurrentGear.ToString());
        }

        [Fact]
        public void Ska_ha_växel_1_efter_att_ha_växlat_upp_från_Neutral()
        {
            var gearbox = new GearBox();
            gearbox.ShiftUp();
            Assert.Equal("1", gearbox.CurrentGear.ToString());
        }

        [Fact]
        public void Ska_ha_växel_2_efter_att_ha_växlat_upp_två_gånger_från_Neutral()
        {
            var gearbox = new GearBox();
            gearbox.ShiftUp();
            gearbox.ShiftUp();
            Assert.Equal("2", gearbox.CurrentGear.ToString());
        }

        [Fact]
        public void Perfekta_racet()
        {
            var gearbox = new GearBox();
            gearbox.ShiftUp();
            gearbox.ShiftUp();
            gearbox.ShiftUp();

            Assert.Equal("3", gearbox.CurrentGear.ToString());
            
            gearbox.ShiftDown();
            gearbox.ShiftDown();
            gearbox.ShiftDown();
            
            Assert.Equal("N", gearbox.CurrentGear.ToString());
        }

        [Fact(Skip="")]
        public void SparaNerTillDatabas()
        {
            var db = new GearBoxDbContext();
            var gearbox = new GearBox();
            //gearbox.ShiftUp();
            //gearbox.ShiftUp();

            db.GearBoxes.Add(gearbox);
            db.SaveChanges();

        }





    }
}
