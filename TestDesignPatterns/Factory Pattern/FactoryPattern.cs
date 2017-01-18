using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    #region abstract superclass
    public abstract class Pizza
    {
        public void Prepare()
        {
        }

        public void Bake()
        {
        }

        public void Cut()
        {
        }

        public void Box()
        {
        }
    }
    #endregion

    #region concrete pizza subclasses

    public class CheesePizza : Pizza
    {
    }

    public class PepperoniPizza : Pizza
    {
    }

    public class ClamPizza : Pizza
    {
    }

    public class VeggiePizza : Pizza
    {
    }

    #endregion

    #region client code (the code that use the patterns and the code that most likely to change)
    
    // PizzaStore 1st design
    public class PizzaStore
    {
        SimplePizzaFactory factory;

        // constructor
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        // methods
        public Pizza OrderPizza()
        {
            //Pizza pizza = new Pizza(); // every time when you use the "new" keyword, you are programming to a concrete implementation.

            Pizza pizza = factory.CreatePizza("cheese"); // now, there is no "new" keyword, so we are not programming to an implementation.

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }

    // PizzaStore 2nd design. Make it abstract and we can have multiple regional stores.
    public abstract class PizzaStore2
    {
        // this is a concrete implementation because i do want all subclass to use this same fixed process.
        public Pizza OrderPizza(string PizzaType)
        {
            Pizza pizza = CreatePizza(PizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        // the "factory method" is now abstract in PizzaStore2.
        // make this CreatePizza method abstract because it allows subclass to decide how to implement their regional pizza style.
        public abstract Pizza CreatePizza(string PizzaType);
    }

    // 2nd design. concrete pizza store
    public class NYPizzaStore : PizzaStore2
    {

        public override Pizza CreatePizza(string PizzaType)
        {
            if (PizzaType.Equals("cheese"))
            {
                return new CheesePizza();
            }
            else if  (PizzaType.Equals("veggie"))
            {
                return new VeggiePizza();
            }
            else if  (PizzaType.Equals("clam"))
            {
                return new ClamPizza();
            }
            else if  (PizzaType.Equals("pepperoni"))
            {
                return new PepperoniPizza();
            }
            return null;
        }
    }

    #endregion

    // simple factory (not the real factory pattern). this is the only part of the application that refers to concrete pizza classes.
    public class SimplePizzaFactory
    {

        // method
        public Pizza CreatePizza(string PizzaType)
        {
            Pizza pizza = null;

            if (PizzaType.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (PizzaType.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (PizzaType.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            else if (PizzaType.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }

}
