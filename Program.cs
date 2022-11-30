using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Rezolvarea ecuatiei de gradul al doilea");
		Console.Write("\n");
		float a;
		float b;
		float c;
		float d;
		float x1;
		float x2;

		Console.Write("a = ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("b = ");
		b = Convert.ToInt32(Console.ReadLine());
		Console.Write("c = ");
		c = Convert.ToInt32(Console.ReadLine());

		if (a != 0F && b != 0F)
		{

			{
				d = b * b - 4 * a * c;
			}

			if (d >= 0F)
			{
				x1 = (float)((-b + Math.Sqrt(d)) / (2 * a));
				x2 = (float)((-b + Math.Sqrt(d)) / (2 * a));
				Console.Write("x1=");
				Console.Write(x1);
				Console.Write("\n");
				Console.Write("x2=");
				Console.Write(x2);
				Console.Write("\n");
			}
			else
			{
				if (d < 0F)
				{
					Console.Write("Ecuatia nu are solutii in R");
				}
			}
		}
		if (a == 0F && b == 0F && c == 0F)
		{
			Console.Write("Ecuatia are o infinitate de solutii!");
		}
		else
		{
			if (a == 0F && b == 0F)
			{
				Console.Write("Ecuatia nu are solutii!");
			}
			else
			{
				if (a == 0F)
				{
					if (c != 0F)
					{
						x1 = -b / c;
						Console.Write("x=");
						Console.Write(x1);
					}
					else
					{
						Console.Write("Ecuatia nu are solutii!");
					}
				}
				else
				{
					if (b == 0F)
					{
						if (-c / a >= 0F && c != 0F)
						{
							x1 = (float)Math.Sqrt(-c / a);
							Console.Write("x=");
							Console.Write(x1);
						}
						else
						{
							if (c == 0F)
							{
								Console.Write("x=0");
							}
							else
							{
								Console.Write("Ecuatia nu are solutii!");
							}
						}
					}
				}
			}
		}
	}
}
