using lego_mini_bois.Heads;
using lego_mini_bois.Torsos;
using System;
using System.Collections.Generic;

namespace lego_mini_bois
{
    // -INHERITANCE:
    // -"is a"
    // -"A duck is a bird." ducks are bird and have certain behaviors for being birds.
    // -Get traits/behaiviors for 'free'.
    // - can only inherit from one thing.
    // -COMPOSITION:
    // -taking small things and putting them together to perform a big job.
    // -what makes up a thing
    // -"has a"
    // -"A duck has a bill." -is made up of x,y,z.
    // -combining a bunch of parts to make one whole thing/to do one big job.
    // - no limit on how many things can be composed of.

    // hit the CONTROL key and click and it will take you
    // to go back hit CONTROL key and minus key
    // CONTROL SHIFT minus moves forward
    class Program
    {
        static void Main(string[] args)
        {
            var workerHead = new ConstructionWorkerHead();

            workerHead.Color = LegoColor.Yellow;

            var batmanHead = new BatmanHead();
            batmanHead.SayHi();

            var astronautHead = new AstronautHead();
            astronautHead.SayHi();

            // var weirdHead = new HeadBase();

            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead };

            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
            }
            var batSuitTorso = new BatSuitTorso();
            batSuitTorso.BodyColor = LegoColor.Purple;
            batSuitTorso.HasBatBoomerang = true;
            batSuitTorso.HasShirt = false;
            batSuitTorso.Donates();
        }

    }
}
