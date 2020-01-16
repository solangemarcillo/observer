using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obser_poo
{
	class ServicioSuscrito
	{
		public void alta(Usuario nueva)
		{
			Console.WriteLine("Creando nueva membrecia de suscriptor.", nueva.apellido, nueva.nombre);
			(new Suscribirse()).enviaMensajeAlta(nueva.apellido, nueva.nombre);
			if (nueva.membresia)
			{
				(new ServicioUsuario()).nuevoUsuario(nueva.nombre);
			}
		}

		public List<Nuevamembrasia> observers = new List<Nuevamembrasia>();
		public virtual void registra(Nuevamembrasia observer)
		{
			observers.Add(observer);
		}
		public virtual void especial(Usuario nueva)
		{
			Console.WriteLine("Creada nueva suscripcion.", nueva.apellido, nueva.nombre);
			foreach (Nuevamembrasia observer in observers)
			{
				observer.nueva(nueva);
			}
		}
	}
}
