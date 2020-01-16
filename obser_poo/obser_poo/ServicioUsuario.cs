using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obser_poo
{
	class ServicioUsuario
	{
		internal void nuevoUsuario(string apellido)
		{
			Console.Write("Nuevo miembro ¡listo, te has suscrito.");
		}

		internal void registra(ServicioUsuario servicioUsuario)
		{
			Console.WriteLine("Nuevo Registro ¡listo te has suscrito.");

		}

		internal void nuevoUsuario(ServicioUsuario serviciousuario)
		{
			Console.WriteLine("Nuevo notificacion, !listo te has suscrito.\n");
		}
	}
}
