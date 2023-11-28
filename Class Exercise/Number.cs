using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Exercise
{
    internal class Number
    {


        public static int SecondbiggestNumber(int[] numbers)
        {
            int secondlast = BiggestNumber(numbers);
            int answer = int.MinValue;


            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] > answer) && numbers[i] < secondlast)
                    answer = numbers[i];
            }

            return answer;



        }

        public static int BiggestNumber(int[] numbers)

        {
            int lastbiggestnumber = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] > lastbiggestnumber)
                {
                    lastbiggestnumber = numbers[i];

                }






            }

            return lastbiggestnumber;
        }

           


     }

}

            

        
    
