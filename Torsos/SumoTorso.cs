using lego_mini_bois.Heads;
using System;

namespace lego_mini_bois.Torsos
{
    class SumoTorso : TorsoBase
    {
        public bool AreTheyThicc { get; set; }
        public LegoColor Fundoshi { get; set; }

        public override void Wiggle()
        {
            Console.WriteLine("Shiko!");
        }
        public void FightPrep()
        {
            Console.WriteLine("Spread that salt around");
        }
    }
}
