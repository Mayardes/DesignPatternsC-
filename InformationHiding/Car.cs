using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding
{
    public class Car
    {
        //hiding information details about my car
        // composition class

        private string _brand { get; set;}
        private Engine _engine { get; set; }
        private Batery _batery { get; set; }

        private void Ignition()
        {
            Console.WriteLine("Startup the car..");
        } 

        public string Model {get; set; }

        public Car(string brand)
        {
            this._brand = brand;
        }

        public int FactoryYear { get {return 2021; } private set { } }


        public int NumTires()
        {
            return 4;
        }


        public void ToFillUp()
        {
            Console.WriteLine("Filling up car");
        }
        public void TurnOn()
        {
            Console.WriteLine("Turning on car");
            Ignition();
        }
        public void ToMove()
        {
            Console.WriteLine("Moving car");
        }

    }
}
