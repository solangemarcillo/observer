using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obser_poo
{
	class Program
	{
		static void Main(string[] args)
		{
			string  nombre ,apellido;
			Console.WriteLine("ingrese el nombre ");
			nombre= Console.ReadLine();

			Console.WriteLine("ingrese el apellido");
			apellido = Console.ReadLine();

			ServicioSuscrito suscrito = new ServicioSuscrito();
			ServicioUsuario suscriptor = new ServicioUsuario();
			suscrito.alta(new Suscribirse());
			suscrito.especial(new Suscribirse());
			suscrito.registra(new Suscribirse());
			suscriptor.registra(new ServicioUsuario());
			suscriptor.registra(new ServicioUsuario());
		}
	}
}
