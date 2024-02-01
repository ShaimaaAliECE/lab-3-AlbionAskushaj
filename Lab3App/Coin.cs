using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Coin : Treasure
    {
        public int Value { get; set; }

        public Coin(string description, int score, int value) : base()
        {
            this.Description = description;
            this.Score = score;
            this.Value = value;
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + this.Description + " is displayed");
        }

        protected void UpdateTotalValue()
        {
            Board.TotalValue += Value;
        }

       
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue(); 
        }
    }
}