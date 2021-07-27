using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lego_mini_bois.Heads
{
    class BatmanHead : HeadBase
    {
        public bool IsWearingMask { get; set; }
        public string Version { get; set; }
        public string FacialExpression { get; set; } = "Stoic";
        //public LegoColor Color { get; private set; }

        public BatmanHead()
        {
            Color = LegoColor.Purple;
        }
        public override void Spin()
        {
            Console.WriteLine("Where is the joker?!?!");
        }
        public override void SayHi()
        {
            Console.WriteLine("I'm Batman!");
        }
    }
}
