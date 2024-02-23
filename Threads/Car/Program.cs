using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	class Program
	{
		static void Main(string[] args)
		{
			//Tank tank = new Tank(15);
			//tank.Info();
			//int amount;
			//do
			//{
			//	Console.Write("Введите объем топлива: ");
			//	amount = Convert.ToInt32(Console.ReadLine());
			//	tank.Fill(amount);
			//	tank.Info();
			//} while (amount > 0);

			//Engine engine = new Engine(10);
			//engine.Info();

			Car car = new Car(10, 40);
			car.Info();
			car.Control();
		}
	}
}
