using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
             CD myCD = new CD("Reacher","200-500","Movie","CD");
            DVD myDVD = new DVD("The Book of Daniel", "500-1600", "Movie", "DVD");

            // TODO: Call each CD and DVD method to verify that they work as expected.
            myCD.SpinDisc();
            myDVD.SpinDisc();
        }
    }
}
