using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eventos
{
	class Program
	{
		static void Main(string[] args)
		{
			string Ruta = @"C:\Users\alvar\source\repos\ProgramaEventos\Eventos\Eventos.txt";

			try
			{
				using (StreamReader Documento = new StreamReader(Ruta) )
				{
					string lineas;

					while ((lineas = Documento.ReadLine()) != null)
					{
						Console.WriteLine(lineas);
					}

					Console.ReadKey();
				}

			}
			catch (Exception )
			{

				Console.WriteLine("No se encontró el Archivo");
			}
		}
	}
}

