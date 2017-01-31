using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDesignPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOldWay_Click(object sender, EventArgs e)
        {
            MallardDuckOldWay mallard = new MallardDuckOldWay();
            mallard.display();
            mallard.performFly();
            mallard.performQuack();

            ModelDuckOldWay modelDuck = new ModelDuckOldWay();
            modelDuck.display();
            modelDuck.performFly();
            modelDuck.performQuack();

        }

        private void btnTestObserverPattern_Click(object sender, EventArgs e)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            weatherData.SetMeasurements(99, 12, 34);

        }

        private void btnTestProgramToInterfaces_Click(object sender, EventArgs e)
        {
            ITestInterface1 i; // program to interfaces (do not program to concrete implementations)
            // Programming to an interface allows a program to dynamically change the method logic at run time.
            
            i = new Class1(); // since Class1 implements ITestInterface1, so Class1 "is a" ITestInterface1.
            i.DoSomething();

            i = new Class2(); // since Class2 implements ITestInterface1, so Class2 "is a" ITestInterface1.
            i.DoSomething();

        }

        private void btnTestDecoratorPattern_Click(object sender, EventArgs e)
        {
            Beverage drink1 = new HouseBlend(); // use Beverage type to hold this variable because it can be decorated.

            Console.WriteLine(drink1.GetDescription() + ". cost = " + drink1.cost().ToString());

            drink1 = new Mocha(drink1); // converting an object1 (HouseBlend) to another object2 (Whip) by decoration. Both objects are still a Beverage.

            Console.WriteLine(drink1.GetDescription() + ". cost = " + drink1.cost().ToString());
        }

        private void btnTestStrategyPattern_Click(object sender, EventArgs e)
        {
            // test strategy pattern

            Duck mallard = new MallardDuck(); // note: the object is of the base class type even it is instanciated as a subclass type.

            // This is a base class method but the base class does not have concrete implementation. 
            // It delegates to the object's QuackBehavior on the duck's inherited quackBehavior reference.
            mallard.performQuack();
            mallard.performFly();


            Duck model = new ModelDuck();
            model.performFly(); // performFly() delegates to the flyBehavior object set in the ModelDuck's constructor, which is a FlyNoWay instance.

            model.setFlyBehavior(new FlyRocketPowered()); // Change behavior at runtime. You can't do that if the implementation lives inside the duck class.
            model.performFly();
        }
    }
}
