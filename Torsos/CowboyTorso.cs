using System;

namespace lego_mini_bois.Torsos
{
    class CowboyTorso : TorsoBase
    {
        public bool HasPullString { get; set; }
        public bool HasHolster { get; set; }
        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("There's a snake in my boot!");
        }
        public override void Wiggle()
        {
            Console.WriteLine("Draws bananas for good health.");
        }
        public void LassoDance()
        {
            Console.WriteLine("Move like a cowboy!");
        }
    }
}
