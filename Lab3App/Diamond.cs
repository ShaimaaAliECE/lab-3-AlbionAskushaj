using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{

    internal class Diamond : Treasure
    {
        public Diamond(string description, int score) : base()
        {
            this.Description = description;
            this.Score = score;
        }

        public override void Display()
        {
            Console.WriteLine("Diamond " + this.Description + " is displayed");
        }


    }

}