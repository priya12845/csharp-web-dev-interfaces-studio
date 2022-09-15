using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class Disc
    {
        public  string Name { get; set; }
        public  string Capacity { get; set; }
        public  string Contents { get; set; }

        public   string Disctype { get; set; }

        public Disc(string name, string capacity, string contents, string disctype)
        {
            Name = name;
            Capacity = capacity;
            Contents = contents;
            Disctype = disctype;
        }



        //public abstract string CanSpin { get; set; }


    }
}
