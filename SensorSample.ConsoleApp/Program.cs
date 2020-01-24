using System;
using SensorSample.Logic;

namespace SensorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Sensor livingRoomTemperature = new Sensor("Living Room", DoSomeLogging);
            Sensor officeTemperature = new Sensor("Office", DoSomeLogging);

            //livingRoomTemperature.TemperatureMeasured += TemperatureMeasured;
            //officeTemperature.TemperatureMeasured += TemperatureMeasured;

            for (int i = 0; i < 100; i++)
            {
                livingRoomTemperature.MeasureTemperature();
                officeTemperature.MeasureTemperature();
            }

        }

        private static void DoSomeLogging(object sender, string text)
        {
            Console.WriteLine(text);
        }


        private static void TemperatureMeasured(object sender, double temperature)
        {
            Console.WriteLine($"[{sender.ToString()}] Neue Temperatur: {temperature}");
        }
    }
}
