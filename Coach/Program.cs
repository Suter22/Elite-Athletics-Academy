using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int u;
            int j;
            int t;
            float time;
            float temp;
            int lane;
            lane = 0;
            float Wrecord;
            float Erecord;
            float Brecord;

            Console.Write("Male Or Female Race[F/M]? ");
            string gender = Console.ReadLine();

            if ( gender == "M")
            {
                Wrecord = 9.58f;
                Erecord = 9.86f;
                Brecord = 9.87f;

            }
            else
            {
                Wrecord = 10.49f;
                Erecord = 10.73f;
                Brecord = 10.99f;
            }

            List<float> times = new List<float> { };

            for(t = 0; t < 8; t++)
            {
                lane = lane + 1;
                Console.Write("Input Lane " + lane + (" ") );
                time = float.Parse(Console.ReadLine());
                times.Add(time);

                if (time < Wrecord)
                {
                    Console.WriteLine("World Record Broken");
                }
                else if (time < Erecord)
                {
                    Console.WriteLine("European Record Broken");
                }
                else if (time < Brecord)
                {
                    Console.WriteLine("British Record Broken");
                }
            }

            u = times.Count;

            for (i = 0; i <= u - 1; i++)
            {
                for (j = 0; j < u - i - 1;j++)
                {
                    if (times[j] > times[j+ 1])
                    {
                        temp = times[j];
                        times[j] = times[j + 1];
                        times[j + 1] = temp;
                    }
                }
            }

            for(i = 0; i < u; i++)
            {
                Console.WriteLine(times[i] + " ");
            }
            Console.ReadKey();

        }
    }
}
