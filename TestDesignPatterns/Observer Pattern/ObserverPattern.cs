using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    #region Interfaces

    // subject interface
    public interface ISubject
    {
        void RegisterObserver(IObserve o);
        void RemoveObserver(IObserve o);
        void NotifyObservers();
    }

    // observer interface
    public interface IObserve
    {
        void Update(decimal temperature, decimal humidity, decimal pressure);
    }

    // display element interface
    public interface IDisplayElement
    {
        void Display();
    }

    #endregion


    #region The Subject

    public class WeatherData : ISubject
    {
        private decimal _temperature;
        private decimal _humidity;
        private decimal _pressure;

        private List<IObserve> observers;

        // constructor
        public WeatherData()
        {
            observers = new List<IObserve>();
            _temperature = 0;
            _humidity = 0;
            _pressure = 0;
        }

        // implemented ISubject methods
        public void RegisterObserver(IObserve o)
        {
            observers.Add(o);
        }
        public void RemoveObserver(IObserve o)
        {
            observers.Remove(o);
        }
        public void NotifyObservers()
        {
            foreach (IObserve x in observers)
            {
                x.Update(_temperature, _humidity, _pressure);
            }
        }

        public void measurementChanged()
        {
            NotifyObservers();
        }

        // this method is for testing purpose only
        public void SetMeasurements(decimal temperature, decimal humidity, decimal pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            measurementChanged();
        }
    }

    #endregion



    #region The Observers

    public class CurrentConditionsDisplay : IObserve, IDisplayElement
    {
        private ISubject _weatherData;

        private decimal _temperature;
        private decimal _humidity;

        // constructor
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(decimal temperature, decimal humidity, decimal pressure) // implements IObserve.Update()
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display() // implements IDisplayElement.Display()
        {
            Console.WriteLine(string.Format("Current conditions: temperature {0}F degrees and {1}% humidity.", _temperature.ToString(), _humidity.ToString()));
        }
    }

    public class StatisticsDisplay : IObserve, IDisplayElement
    {
        private ISubject _weatherData;

        //private decimal _temperature = 0;
        //private decimal _humidity = 0;

        // constructor
        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(decimal temperature, decimal humidity, decimal pressure) // implements IObserve.Update()
        {
            //_temperature = temperature;
            //_humidity = humidity;
            Display();
        }

        public void Display() // implements IDisplayElement.Display()
        {
            Console.WriteLine(string.Format("Statistics: temperature {0}F degrees and {1}% humidity.", "12", "34"));
        }
    }


    #endregion
    


    #region
    #endregion



    #region
    #endregion





    class ObserverPattern
    {
    }
}
