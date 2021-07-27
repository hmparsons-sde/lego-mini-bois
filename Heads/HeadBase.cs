using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lego_mini_bois.Heads
{
    // abstract is only good to inherit from. Cannot be instantiated. 
    // abstract class can define the idea of a method.
    // this is the idea of a class.
    abstract class HeadBase
    {
        public LegoColor Color { get; set; }
        // virtual can change the behavior but you dont have to
        public virtual void SayHi()
        {
            Console.WriteLine("Hi.");
        }

        // this is the idea of a method.
        public abstract void Spin();
    }
}
