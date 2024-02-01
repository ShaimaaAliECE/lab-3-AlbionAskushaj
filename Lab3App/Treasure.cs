using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Treasure : Collectable
    {
        public int Score { get; set; }

        void UpdateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalScore(); 
        }

    }
}