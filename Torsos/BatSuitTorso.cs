using System;

namespace lego_mini_bois.Torsos
{
    class BatSuitTorso : TorsoBase
    {
        public bool HasBatBoomerang { get; set; }
        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("Fist Bump");
        }
        public override void Wiggle()
        {
            Console.WriteLine("Flexin");
        }

        public void Donates()
        {
            Console.WriteLine("Donates $150mil to Children of the Future");
        }
    }
}
