using System;

namespace lego_mini_bois.Legs
{
    class MagicLeg : LegBase
    {
        public bool HasInvisibleLegs { get; set; }
        public int Length { get; set; } //in inches

        public void MeasuringLegs(string size) // small, medium, large
        {
            if (size == "small")
            {
                Length = 4;
            }
            else if (size == "medium")
            {
                Length = 8;
            }
            else if (size == "large")
            {
                Length = 16;
            }
            else
            {
                Length = 1;
            }
        }


        public override void Walk()
        {
            Console.WriteLine("We float around on magic carpets, no walking allowed.");
        }

    }
}
