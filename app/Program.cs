using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] stringsOld = new string []{"Вы","третий","в","очереди","tri"};
            string [] stringsNew = new string [stringsOld.Length];
            int count = 0;

            for (int i = 0; i < stringsOld.Length; i++)
            {   
                
                if(stringsOld[i].Length<=3)
                {
                    stringsNew[count] = stringsOld[i];
                    count++;
                }
            }

            foreach (string line in stringsNew)
            {
                if(line != null)
                Console.Write("["+line+"] ");
            }
        }
    }
}
