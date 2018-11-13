using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace week2_day2
{
    class SharpieSet
    {
        public List<Sharpie> sharpielist = new List<Sharpie>();
        public List<int> usableList=new List<int>();
        public List<Sharpie> unusableList=new List<Sharpie>();
        public List<int> CountUsable()
        {
            for (int i=0; i<this.sharpielist.Count;i++)
            {
                if (sharpielist[i].inkAmount > 0)
                {
                    usableList.Add(i);
                }
                else
                {
                    unusableList.Add(sharpielist[i]);
                }
            }

            return this.usableList;
        }

        public void Removetrash()
        {
            foreach (Sharpie i in unusableList)
            {
                sharpielist.Remove(i);
            }
        }
        

    }
}
