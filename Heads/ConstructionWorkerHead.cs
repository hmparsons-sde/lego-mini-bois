using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lego_mini_bois.Heads
{
    class ConstructionWorkerHead : HeadBase
    {
        // Properties
        public bool HasMullet { get; set; }
        public new LegoColor Color { get; set; }
        public int Teeth { get; set; }
        public bool WearingHardHat { get; set; }

        // Behaviors
        public bool ToggleHat()
        {
            WearingHardHat = !WearingHardHat;
            Console.WriteLine($"The Construction Worker Head {(WearingHardHat ? "is" : "is not")} wearing its hard hat");
            return WearingHardHat;
        }

        public override void SayHi()
        {
            Console.WriteLine("Hi");
        }

        public override void Spin()
        {
            if (Teeth > 0)
            {
                Teeth -= 1;
            }
            Console.WriteLine($"The {Color} Construction Worker Head spins after being hit by a girder");
        }
    }
    //enum LegoColor // defining what possible values there could be for a given thing.
    //{
    //    Yellow,
    //    Red,
    //    Blue,
    //    Purple
    //} // avoids infinite list of values; but defines possibilities.
}
