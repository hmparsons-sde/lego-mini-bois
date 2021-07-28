using lego_mini_bois.Heads;
using System;

namespace lego_mini_bois.Torsos
{
    abstract class TorsoBase
    {
        public bool HasShirt { get; set; }
        public LegoColor BodyColor { get; set; }
        public string ToolBelt { get; set; }

        public virtual void Greeting()
        {
            Console.WriteLine("High five!"); // generic, so all can override.
        }

        public abstract void Wiggle(); // each inherited class will define their own wiggles.
    }
} // every torso will implement these properties + methods
