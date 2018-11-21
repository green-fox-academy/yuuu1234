using System;
using System.Collections.Generic;
using System.Text;

namespace StructAndGeneric
{
    class Container<T>
    {
        private List<T> containerList;

        public Container()
        {
            this.containerList=new List<T>();
        }

        public void Add(T element)
        {
            bool hasIn = false;
            if (this.containerList.Count > 0)
            {
                foreach (T c in containerList)
                {
                    if (c.ToString() == element.ToString())
                    {
                        hasIn = true;
                    }

                }
            }

            if (hasIn == false|| this.containerList.Count == 0)
            {
                
                containerList.Add(element);
            }
        }

        public string ToString()
        {
            string result="";
            foreach (T c in this.containerList)
            {
                result += c.ToString() + " ";
            }

            return result;
        }
    }
}
