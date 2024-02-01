using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Collectable : Displayable
    {
        public string Description { get; set; }

        public CollectionBoard Board { get; set; }  

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            if(this is Tool tool)
            {
                tool.DoAction();
            }

        }

        public virtual void Display() { }

    }
}