using System;
namespace SpinningDiscs
{
    public class CD : Disc , IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
           public CD(string name, string capacity,string contents,string disctype) : base(name,capacity,contents,disctype)
        {
           
        }

        public void SpinDisc()
        {
            Console.WriteLine(Name + " spins at a rate of " + Capacity + " rpm");
        }
    }
}
