using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	class Tank
	{
		static readonly int MIN_VOLUME = 20;
		static readonly int MAX_VOLUME = 120;
		public readonly int Volume;
		double fuel_level;
		
		public double FuelLevel
		{
			get => fuel_level;
		}
		public Tank(int volume)
		{
			if (volume < MIN_VOLUME) volume = MIN_VOLUME;
			if (volume > MAX_VOLUME) volume = MAX_VOLUME;
			this.Volume = volume;
			fuel_level = 0;
		}
		public void Fill(double amount)
		{
			if (amount < 0) return;
			if (fuel_level + amount <= Volume) fuel_level += amount;
			else fuel_level = Volume;
		}
		public void Info()
		{
			Console.WriteLine($"Tank volume: {Volume}");
			Console.WriteLine($"Fuel level:  {FuelLevel}");
		}
	}
}
