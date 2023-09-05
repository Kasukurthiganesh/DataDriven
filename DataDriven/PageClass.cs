using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDriven
{
     class PageClass 
    {
        
        public void name()
        {

            Console.WriteLine("Hi Ganesh this method is showing from anthore class");
        
        }
        // Read and Write Property
        private int Id;
        private string _Name;
        //Syntax for Read only property
        /*Access_Modifier(public or private) DataType(Int or string or Varchar) PropertyName(Exmp =ValueID)
           {get{return DataFieldName;}}
        */
        //Syntax for Wirteonly property
        /*Access_Modifier(public or private) DataType(Int or string or Varchar) PropertyName(Exmp =ValueID)
           {set{DataFieldName = value;}}
        */
        public int Valueid
        {
            set { Id = value; }
            get { return Id; }
        }
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        // Readonly and Writeonly Property  only
        public int num1, num2, results;
        public int setNum1
        {
            set { num1 = value; } 
        }
        public int setNum2
        {
            set { num2 = value; }
        }
        public int getresults
        {
            get { return results; }
        }

        public void add()
        {
            results = num1 + num2;
        }
        public void sub()
        {
            results = num1 - num2;
        }

        
    }
    class autoImp
    {
       
        public int id { get; set; }
        public string Name { get; set; }
        public int Results { get; set; }

        public void add2()
        {
            int num1 = 100;
            int num2 = 300;
            Results = num1 + num2;
            Console.WriteLine("Last propertie checking");
        }
    }
}
