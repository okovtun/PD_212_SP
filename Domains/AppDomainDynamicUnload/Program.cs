using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AppDomainDynamicUnload
{
	class Program
	{
		static void Main(string[] args)
		{
			//1) Создаем домен прилодения:
			AppDomain domain = AppDomain.CreateDomain("Demo");

			//2) Загружаем DLL в домен:
			Assembly asm = domain.Load(AssemblyName.GetAssemblyName("SampleLibrary.dll"));

			//3) Получаем модуль, из которого будем вызывать функцию:
			Module module = asm.GetModule("SampleLibrary.dll");

			//4) Получаем класс, который содержит нужный метод:
			Type type = module.GetType("SampleLibrary.SampleClass");

			//5) Вынимаем метод из класса:
			MethodInfo method = type.GetMethod("Print");

			//6) Вызываем метод:
			method.Invoke(null, null);
		}
	}
}
