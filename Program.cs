using lego_mini_bois.Heads;
using lego_mini_bois.Torsos;
using lego_mini_bois.Minifigures;
using lego_mini_bois.Legs;
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

            var astronautHead = new AstronautHead();

            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead };

            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
            }

            var batmanTorso = new BatSuitTorso();
            batmanTorso.BodyColor = LegoColor.Green;
            batmanTorso.HasBatBoomerang = true;
            batmanTorso.HasShirt = false;
            batmanTorso.Donates();

            var cowboyTorso = new CowboyTorso();

            var sumoTorso = new SumoTorso();

            var torsos = new List<TorsoBase>() { batmanTorso, cowboyTorso, sumoTorso };

            foreach (var torso in torsos)
            {
                torso.Greeting();
                torso.Wiggle();
            }


            var seaLeg = new SeaLeg();
            seaLeg.AreWobbly = true;
            seaLeg.Bottoms = Bottoms.Chaps;
            seaLeg.NumberOfLegs = 3;
            seaLeg.Kicks = Shoes.ShelltoeAdidas;


            var magicLeg = new MagicLeg();
            magicLeg.Bottoms = Bottoms.Chaps; //this is a magical moment
            magicLeg.HasInvisibleLegs = true;
            magicLeg.MeasuringLegs("small");
            Console.WriteLine($"Magic legs have a length of {magicLeg.Length} inches.");

            var legs = new List<LegBase>() { seaLeg, magicLeg };

            foreach (var leg in legs)
            {
                leg.Dance();
                leg.Walk();
            }

            Console.WriteLine("Before Bob.");


            //var bob = new Minifigure(workerHead, cowboyTorso, new SeaLeg());
            var bob = new Minifigure(workerHead, cowboyTorso, seaLeg);
            bob.BuildIt();


            Console.WriteLine("You just saw Bob do his thang!");
            Console.ReadLine();

        }
    }
}
