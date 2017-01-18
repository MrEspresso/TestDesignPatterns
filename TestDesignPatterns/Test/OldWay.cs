using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{


    #region base class

    public abstract class OldDuck
    {
        public abstract void display(); // subclass must implement its own display method.

        public void performFly()
        {
            Console.WriteLine("I am flying.");
        }

        public void performQuack()
        {
            Console.WriteLine("Quack.");
        }
    }

    #endregion


    #region subclasses

    public class MallardDuckOldWay : OldDuck
    {

        public override void display()
        {
            Console.WriteLine("I am a real Mallard duck.");
        }
    }

    public class ModelDuckOldWay : OldDuck
    {
        public override void display()
        {
            Console.WriteLine("I am a real model duck.");
        }
    }

    #endregion
        
}
