using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    // Decorator Pattern is additive (on the other hand, Strategy Pattern is a replacement). It allows adding new behaviors at runtime.
    // Extension at runtime (it is a form of object composition), not compile time.
    // With decoration, you can give objects new responsibilities without making any code changes to the underlying classes.

    #region superclasses (beverage. the component)

    public abstract class Beverage
    {
        protected string description = "Unknow Beverage";

        public virtual string GetDescription() // virtual = can be overridden
        {
            return description;
        }

        public abstract decimal cost();
    }

    #endregion 

    #region the abstract decorator (it is still the same type as the component)

    public abstract class CondimentDecorator : Beverage // we need this decorator to be interchangeable with a Beverage, so we inherit from the Beverage class.
    {
        // we need a new CondimentDecorator class instead of just using the Beverage class in the decorator because
        // we can implement some common behaviors across all Condiments.

        //public abstract new string GetDescription();
    }

    #endregion

    #region subclasses (coffee)

    public class Espresso : Beverage
    {
        // constructor
        public Espresso()
        {
            description = "Espresso";
        }

        public override decimal cost()
        {
            return 1.99M;
        }
    }

    public class HouseBlend : Beverage
    {
        // constructor
        public HouseBlend()
        {
            description = "House Blend"; // question: how do I know the description will need to be set?
        }

        public override decimal cost() // implement abstract methods defined by the superclass (always right click on the superclass and click Implement Abstract Methods)
        {
            return 0.89M;
        }
    }

    #endregion

    #region subclasses (the decorators = the condiments)

    // this is an example of a decorator
    public class Mocha : CondimentDecorator
    {
        // private variables
        protected Beverage beverage;

        // constructor
        public Mocha(Beverage b)
        {
            beverage = b;
        }

        public override string GetDescription() // implement the abstract method defined in the superclass
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override decimal cost() // implement the abstract method defined in the superclass
        {
            return beverage.cost() + 0.2M;
        }
    }

    public class Whip : CondimentDecorator
    {
        // need a variable to hold the component
        protected Beverage beverage;

        // constructor for passing in the component for this decorator
        public Whip(Beverage b)
        {
            beverage = b;
        }

        // implement the abstract methods
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip"; // deorating the component with new stuff
        }

        // implement the abstract methods
        public override decimal cost()
        {
            return beverage.cost() + 0.1M; // deorating the component with new stuff
        }
    }


    #endregion

}
