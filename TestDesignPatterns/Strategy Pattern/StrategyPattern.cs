// Chapter 1 Intro to Design Patterns

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TestDesignPatterns
{
    // Each region represent a code file

    #region base class (abstract)

    public abstract class Duck
    {
        // This is a bad design because not all ducks (subclasses) can fly.
        //public void fly()
        //{
        //    Console.WriteLine("I am flying.");
        //}

        // Using the virtual keyword to allow overriding this method is not a good idea either because each subclass will individually need to override this method.
        //public virtual void fly()
        //{
        //    Console.WriteLine("I am flying.");
        //}

        // Forceing subclasses to implment the fly method is not a good idea becuase each subclass will need to implement the method itself (no code reuse or duplicate code).
        //public abstract void fly(); 

        // Using an interface is not a good idea either because each subclass will need to implement the method itself (no code reuse or duplicate code).

        // Inheritance does not work out very well because the duck behavior keeps changing across the subclasses, and it is not appropriate for
        // all subclasses to have those behaviors.

        // Design principle: identify the aspects of your application that vary and separate them from what stays the same.


        // What should we improve? Page 11
        // Pull out what varies (the duck behaviors) Page 15
        // When we instantiate a new MallardDUck instance, intitialize it with a specific type of flying behavior
        // Be able to change the behavior of a duck dynamically (include a behavior setter methods in the Duck classes so that we can change hte MallardDuck's flying behavior at runtime)

        // Programming to an implementation example (not good)
        // Dog d = new Dog();
        // d.bark();

        // (Recommended) Programming to an interface/supertype example
        // Animal animal = new Dog(); // Animal can be either an abstract class or an interface
        // animal.makeSound();

        // This behavior may have multiple implementations and new implementations will be added in the future.
        // Therefore, this behavoir is highly likely to change and should be taken out of the super class and subclasses.
        // "Program to an interface" can achieve that. This super class has a performFly method but the subclasses can setup or change the behavior at runtime.
        // Rather than handling the fly behavior in this class, the Duck object delegates that behavior to the object referenced by flyBehavior.
        // The subclass will set the flyBehavior to a concrete fly behavior class.
        public IQuackBehavior quackBehavior; // this instance variable will hold a reference to a concrete behavior at runtime. the interface garantees there is a quack() method.
        public IFlyBehavior flyBehavior; // this instance variable will hold a reference to a concrete behavior at runtime. The interface garantees there is fly() method.

        // Design principle: Favor composition over inheritance
        // Inheritance: inherit behavior statically at compile time. Changes in the superclass can unintentionally affect the subclasses.
        // Composition: extend an object's behavior dynamically at runtime. By dynamically composiing objects, I can add new functionality by writing new code rather than modifying existing code. The chances of introducing bugs or causing unintended side effects in pre-existing code are much reduced. 

        public abstract void display();

        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void performQuack()
        {
            quackBehavior.quack(); // Since this behavior varies among subclasses, it should be taken out and implemented in a separate behavior class.
        }

        public void performFly()
        {
            flyBehavior.fly(); // Since this behavior varies among subclasses, it should be taken out and implemented in a separate behavior class.
        }

        public void swim() // Since this behavior does not vary among subclasses, it can be implemented here as a concrete implementation.
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
    
    #endregion

    #region subclasses (concrete)

    // a concrete class that inherits interfaces from the base class.
    public class MallardDuck : Duck
    {
        // constructor
        public MallardDuck()
        {
            quackBehavior = new Quack(); // quackBehavior is a vairable from the base class. Quack is a concrete class (behavior) that implements the IQuackBehavior interface.
            flyBehavior = new FlyWithWings(); // flyBehavior is a variable from the base class. FlyWithWings is a concrete class (behavior) that implements the IFlyBehavior interface.
        }

        // Subclass specific methods. Base class requires all subclasses to implement their own version of display().
        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
    }

    // a concrete class that inherits interfaces from the base class.
    public class ModelDuck : Duck
    {
        // constructor
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay(); // interface = class
            quackBehavior = new Quack(); // interface = class
        }

        // Subclass specific methods. Base class requires all subclasses to implement their own version of display().
        public override void display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }

    #endregion
    
    #region Encapsulated behavior 1 (concrete) 

    // that are likely to change in the future and not all subclasses use the same set of behaviors

    /// <summary>
    /// This is an interface that all flying classes should implement. 
    /// </summary>
    public interface IFlyBehavior
    {
        void fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }

    public class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with a rocket.");
        }
    }

    #endregion

    #region Encapsulated behavior 2 (concrete)

    // this is how to define and implement different behavior for the same method name (quack)

    /// <summary>
    /// This is an interface that all quacking classes should implement.
    /// </summary>
    public interface IQuackBehavior
    {
        void quack();
    }

    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }

    #endregion

}
