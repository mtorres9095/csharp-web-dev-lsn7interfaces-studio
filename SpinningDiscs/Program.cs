using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            DVD test_dvd = new DVD("super fast", 100.5, "terminator");
            CD test_cd = new CD("Slow mode", 45.3, "La cucaracha");


            // TODO: Call each CD and DVD method to verify that they work as expected.

            test_dvd.PlayMovie();
            test_cd.PlayMusic();


        }
            
    }
}
