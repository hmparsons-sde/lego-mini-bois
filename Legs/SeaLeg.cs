using System;

namespace lego_mini_bois.Legs
{
	class SeaLeg : LegBase
	{
		public bool AreWobbly { get; set; }
		public int NumberOfLegs { get; set; }

		public void Swim()
		{
			Console.WriteLine("I'm a certified swimmer.");
		}


		public override void Walk()
		{
			Console.WriteLine("Currently moonwalking off the plank, HALPP!");
		}
	}
}