using MakeMyTrip.PageObjects;
using MakeMyTrip.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTrip.Tests
{
    public class HomePage_Test :Base
    {
        [Test]
        [Category("Smoke")]
        public void homepage()
        {
            Homepage hp = new Homepage(getDriver());
             Thread.Sleep(5000);  
             hp.getpopup();
             hp.ListofMenu();
             hp.SelectofMenu("Activities");
             hp.SelectofMenu("Trains");
             Thread.Sleep(5000);

        }
    }
}
