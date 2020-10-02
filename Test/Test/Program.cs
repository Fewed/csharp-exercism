using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new List<string> { "2234567890", "+1 (223) 456-7890" };
            //var res = test.Select(PhoneNumber.Clean);
            //foreach (var item in res) Console.Write($"{item} ");

            var cl = new Clock(0, 1441);
            Console.WriteLine(cl.ToString());
        }





        public class Clock
        {
            int hours = 0;
            int minutes = 0;



            Clock UpdateTime(int extraHrs = 0, int extraMins = 0)
            {
                var temp = (minutes + extraMins + 60 * (hours + extraHrs)) % (24 * 60);
                if (temp < 0) temp += 24 * 60;
                hours = (temp / 60) % 24;
                minutes = (temp - 60 * hours) % 60;
                return this;
            }

            public override string ToString()
            {
                var strHrs = $"{(hours < 10 ? "0" : "")}{hours}";
                var strMins = $"{(minutes < 10 ? "0" : "")}{minutes}";
                return strHrs + ":" + strMins;
            }

            public Clock(int hours, int minutes) => UpdateTime(hours, minutes);


            public Clock Add(int minutesToAdd) => UpdateTime(extraMins: minutesToAdd);

            public Clock Subtract(int minutesToSubtract) => UpdateTime(extraMins: -minutesToSubtract);
        }



        //public void On_the_hour()
        //{
        //    var sut = new Clock(8, 0);
        //    Assert.Equal("08:00", sut.ToString());
        //}

        //[Fact(Skip = "Remove this Skip property to run this test")]
        //public void Past_the_hour()
        //{
        //    var sut = new Clock(11, 9);
        //    Assert.Equal("11:09", sut.ToString());
        //}

        //[Fact(Skip = "Remove this Skip property to run this test")]
        //public void Midnight_is_zero_hours()
        //{
        //    var sut = new Clock(24, 0);
        //    Assert.Equal("00:00", sut.ToString());
        //}

        //[Fact(Skip = "Remove this Skip property to run this test")]
        //public void Hour_rolls_over()
        //{
        //    var sut = new Clock(25, 0);
        //    Assert.Equal("01:00", sut.ToString());
        //}

        //[Fact(Skip = "Remove this Skip property to run this test")]
        //public void Hour_rolls_over_continuously()
        //{
        //    var sut = new Clock(100, 0);
        //    Assert.Equal("04:00", sut.ToString());
        //}

        //[Fact(Skip = "Remove this Skip property to run this test")]
        //public void Sixty_minutes_is_next_hour()
        //{
        //    var sut = new Clock(1, 60);
        //    Assert.Equal("02:00", sut.ToString());
        //}

        //[Fact(Skip = "Remove this Skip property to run this test")]
        //public void Minutes_roll_over()
        //{
        //    var sut = new Clock(0, 160);
        //    Assert.Equal("02:40", sut.ToString());

    }
}
