using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class functions
    {
      void msg()
        {
            Console.WriteLine("my name is saad");
        }
        void name( string name )
        {
            Console.WriteLine($"my name is {name}");
        }
        public class student()
        {
            public int stdid;
            public string name;
            public string gender;
            public string @class;

            public string details()
            {
                return $"stdid is {stdid} and stdname is {name} and stdgender is {gender} and class is {@class}";
            }
        }


        static void main(string[] args)
    {
            Console.WriteLine("hlo world");
            functions obj = new();
            obj.msg();
            obj.name("saad");

            //student std = new();
            //std.stdid = 1;
            //std.name = "saad";
            //std.gender = "male";
            //std.@class = "12 class";
            //Console.WriteLine(std.details);

            double_cabin obj1 = new double_cabin("toyota", "fortuner", "black");
            obj1.varient();
        }
        

    }


}
