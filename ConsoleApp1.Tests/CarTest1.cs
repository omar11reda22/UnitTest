using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Tests;

[TestClass]
public sealed class CarTest1
{

    // assert 

    [TestMethod]
    public void timetocoverdistanceTest()
    {
        //arrange 

        Car car = new Car()
        {
            Velocity = 500
        };

        var distanse = 100;
        var expectedresult = 200; 
        // act 

        var actual = car.Timetocoverdistance(distanse); 

        // assert 

        Assert.AreEqual(expectedresult, actual); 

    }

    [TestMethod]
    public void teststate() {

        var car1 = new Car()
        {
            Type = CarType.Audi
        };
        var car2 = new Car()
        {
            Type = CarType.Audi
        };


        var mycar1 = car1.getmycar(); 
        var mycar2 = car2.getmycar(); 

        Assert.AreEqual(car1, mycar1);  // areequal based on identity will failed 

       


 
    }

    // string assert 

    //[TestMethod] 
    //public void getdirection()
    //{
    //    var car = new Car() { 
    //      DriveMod = DriveMods.Forward 
    //    };

    //    var mycar = car.getdirection();
    //  //  var expected = "stopped";

    //    // match regex 

    //    StringAssert.Matches(mycar,new System.Text.RegularExpressions.Regex("forward"));
    //}

    [TestMethod]
    public void testvalidmail()
    {
        var car = new Car()
        {
            carownermail = "omarredaaladeeb@gmail.com"
        };

        var mail = car.getownermail();

        StringAssert.Matches(mail, new System.Text.RegularExpressions.Regex("omar@gmail.com"));
    }

    // collection assert 




}
