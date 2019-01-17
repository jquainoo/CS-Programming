using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayOne
{
    //Exercise 2
    public class RequestQueue<T>
    {
        private T[] listOfRequest;
        private int counter;


        public RequestQueue(int size)
        {
            listOfRequest = new T[size];
            counter = 0;

        }

        public bool Add(T tRef)
        {
            if(counter < listOfRequest.Length)
            {
                listOfRequest[counter] = tRef;
                counter++;
                return true;
            }
            return false; 
        }

        public bool ProcessItem()
        {
            if(counter > 0)
            {
                for (int i = 1; i < listOfRequest.Length; i++)
                {
                    listOfRequest[i - 1] = listOfRequest[i];
                }
                counter--;
                return true;
            }
            return false;
        }
        
    }
}
