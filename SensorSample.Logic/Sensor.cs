using System;
using System.Collections.Generic;
using System.Text;

namespace SensorSample.Logic
{
    public class Sensor
    {
        private readonly string _name;

        private EventHandler<string> _loggerMethod;
        
        //public event EventHandler<double> TemperatureMeasured;

        public Sensor(string name, EventHandler<string> loggerMethod)
        {
            _name = name;
            _loggerMethod = loggerMethod;
        }

        public void MeasureTemperature()
        {
            Random random = new Random();
            int temperature = random.Next(1, 40 + 1);
            _loggerMethod(this, $"Es wurde die Temperatur {temperature} gemessen.");
            //OnTemperatureMeasured(temperature);

        }

        //protected virtual void OnTemperatureMeasured(double temperature)
        //{
        //    //TemperatureMeasured?.Invoke(this, temperature);
        //}

        public override string ToString()
        {
            return _name;
        }
    }
}
