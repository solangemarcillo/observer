using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obser_poo
{
	class Suscribirse:Usuario,Nuevamembrasia
	{

		public void nueva(Usuario nueva)
		{
			Console.Write("Nuevo notificacion , !listo te has suscrito.\n", nueva.apellido, nueva.nombre);

		}

		internal void enviaMensajeAlta(string apellido, string nombre)
		{
			Console.Write("Nuevo email: !listo te has suscrito.\n", apellido, nombre);
		}
	}
}
