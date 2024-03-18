using project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Car
    { 
    public int model; 
    public string name;
    public string color;

        public void car()
        {
            Console.WriteLine("parent class");
        }
    }



}
public class double_cabin: Car
{
      public double_cabin(string model,string name,string color) 
        {
            Console.WriteLine($"the model of car is{model} and name of car is {name} and color of car is {color}");
        }

        public void varient()
        {
            Console.WriteLine("child class");
        }

    static void main(string[] args)
    {
        double_cabin obj1 = new double_cabin("toyota", "fortuner", "black");
        double_cabin child = new double_cabin("honda", "civic", "white");
        obj1.varient();
        
    }

}
