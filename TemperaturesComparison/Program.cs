using System;
using static System.Console;

namespace TemperaturesComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temps = new double[5]; // positions [0][1][2][3][4]
            string input;
            double temp;
            double total = 0;

            const double MIN = -30; //minium allowed temp
            const double MAX = 130; //max allowed temp
            int x = 0;

            bool warmer = true;
            bool cooler = true;

            /*
             * Get and check the user input
             */
            while(x < 5) // could use x < temps.Length instead
            {
                input = ReadLine();
                temp = Convert.ToDouble(input);

                if( temp >= MIN && temp <= MAX)
                {
                    
                    if (x > 0)// see if result has been entered into array
                    {
                        
                        if (temp > temps[x-1])
                        {
                            cooler = false;
                        } else if (temp < temps[x-1])
                        {
                            warmer = false;  
                        }
                    }
                    temps[x] = temp;
                    ++x;
                }
                else
                {
                    WriteLine("Invalid Temp, please re-enter");
                }
            }


            /*
             * Display the output
             */
            
            if(warmer == true)
            {
                Write("Getting warmer:     ");
            } else if (cooler == true)
            {
                Write("Getting cooler:     ");
            } else
            {
                Write("It’s a mixed bag:     ");
            }


            for(int i = 0; i < 5; ++i)
            {
                total += temps[i];
                Write("{0}   ", temps[i]);
            }
            WriteLine("");
            double avg = total / 5;
            WriteLine("Average: {0}", avg);
        }
    }
}
