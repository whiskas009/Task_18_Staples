using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18_Staples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пожаулйста скобки: ");
            string sequenceStaples = Console.ReadLine();
            int sumForCheck = 0;
            int depthSequenceLeft = 0;
            int depthSequenceRight = 0;

            foreach (char symbolStaples in sequenceStaples)
            {
                if (symbolStaples == '(')
                    sumForCheck++;
                else if (symbolStaples == ')')
                    sumForCheck--;

                if (sumForCheck < 0)
                    break;
            }
            
            if (sumForCheck != 0)
            {
                Console.WriteLine("Строка некорректна");
                    return;
            } 

            for (int i = 0; i < sequenceStaples.Length; i++)
            {
                if (sequenceStaples[i] == '(')
                    depthSequenceLeft++;
                else if (sequenceStaples[i] == ')')
                    break;
            }

            for (int i = sequenceStaples.Length - 1; i > 0; i--)
            {
                if (sequenceStaples[i] == ')')
                    depthSequenceRight++;
                else if (sequenceStaples[i] == '(')
                    break;
            }

            if (depthSequenceLeft >= depthSequenceRight)
                Console.WriteLine("Максимальная глубина вхождения: " + depthSequenceLeft);
            else
                Console.WriteLine("Максимальная глубина вхождения: " + depthSequenceRight);

        }
    }
}



