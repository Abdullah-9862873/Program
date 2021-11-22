using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

			//Part a
			int x = 20, y = 35;
			x = y++ + x++;
			y = ++y + ++x;
			Console.WriteLine(x);
			Console.WriteLine(y);
			Console.ReadLine();



			{
				//Part b
				int a = 10, b = 15;
				x = a++;
				y = ++b;
				Console.WriteLine(a);
				Console.WriteLine(b);
				Console.ReadLine();
			}

			{
				//Part c
				int c = 10;
				c++;
				Console.WriteLine(c);
				Console.ReadLine();
			}
			{
				//Part d
				int c = 10;
				Console.WriteLine(c++);
				Console.ReadLine();
			}
			{
				//Part e
				int n = 10;
				int d;
				d = n--;
				Console.WriteLine(d);
				Console.ReadLine();
			}
			{
				//Part f
				int i = 5, j = 6, k = 7, n = 3;
				Console.WriteLine(i + j * k - k % n);
				Console.WriteLine(i / n);
				Console.ReadLine();
			}
			{
				//Part g
				int g;
				float f;
				f = 3;
				// not working accurately
				//g = int(f);
				// Console.WriteLine(g);
				//Console.ReadLine();

			}
			{
				//Part h
				int a = 6;
				Console.WriteLine(a);
				Console.ReadLine();

				a = a + 3;
				Console.WriteLine(a);
				Console.ReadLine();

				a++;
				Console.WriteLine(a);
				Console.ReadLine();

			}
		}
    }
}
