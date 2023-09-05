// See https://aka.ms/new-console-template for more information
using DataDriven;
using System;
using System.Diagnostics;

namespace demo
{
    class Program : InhertanceConcept
    {
        String name;
        int u = 66;
        //constructors
        public Program(string name)
        {
            this.name = name;
        }
        //method
        public void constr()
        {
            Console.WriteLine("This method is consrtr" + this.name);

        }
        public static void Main()
        {

            Program p = new Program("love u ganesh");
            PageClass pc = new PageClass();
            autoImp ai = new autoImp();
            Console.WriteLine("Hi Ganesh");
            //Integer
            int a = 5; int b = 6; int c = 7; int d = 8;
            Console.WriteLine("my number is " + c * a + b + d);
            // String
            String name = " ganesh babu"; String lsname = " kasukurthi"; String middle = " uma maheswari";
            Console.WriteLine("My Full Name is " + lsname + " " + name);
            Console.WriteLine($" my middle name and Full Name is {middle}{lsname}{name}");
            //Varchar
            var Name_Age = "Ganesh 29";
            Console.WriteLine($" my name and age {Name_Age}");
            p.GetMethod1();
            p.GetMethod2();
            pc.name();
            int classin = pc.Valueid = d;
            string classinmethod = pc.Name = name;
            Console.WriteLine(classinmethod);
            Console.WriteLine(classin);
            pc.setNum1 = b;
            pc.setNum2 = a;
            pc.add();
            Console.WriteLine("Additon is : " + pc.getresults);
            pc.sub();
            Console.WriteLine("Sub is : " +pc.getresults);
            int auto = 100;
            int imp = ai.id = auto;
            Console.WriteLine("Sub is : " + imp);
            String impName= ai.Name = middle;
            Console.WriteLine(impName);
            ai.add2();
            Console.WriteLine("Last value in autoimp" + ai.Results);
            //InhertanceConcept
            p.setdata();
            //InhertanceConcept ic = new InhertanceConcept("ganesh");
            //ic.constr();
            p.constr();



        } 
        public void GetMethod1()
        {
            int c = 7; int d = 8;
            Console.WriteLine("my number is " + c * d);
        }
        public void GetMethod2() 
        {
            int e= 8; int f = 9;
            Console.WriteLine("myGetMethod2 number is " + e + f);
        }



    }
}

