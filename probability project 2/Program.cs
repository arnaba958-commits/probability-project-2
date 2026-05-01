using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probability_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        
                int[] data = {
            115,182,191,31,196,1099,5,172,10,179,83,21,20,21,186,177,195,193,
            188,199,62,109,105,183,110
        };

                Array.Sort(data);

                double Percentile(double[] arr, double p)
                {
                    int index = (int)Math.Ceiling(p * arr.Length) - 1;
                    return arr[index];
                }

                double[] d = data.Select(x => (double)x).ToArray();

                double q1 = Percentile(d, 0.25);
                double q3 = Percentile(d, 0.75);
                double iqr = q3 - q1;

                double lower = q1 - 1.5 * iqr;
                double upper = q3 + 1.5 * iqr;

                Console.WriteLine("Outliers:");

                foreach (var x in data)
                {
                    if (x < lower || x > upper)
                        Console.WriteLine(x);
                }
            }
        }

    }
