using System;
namespace Entrega_Final_ED
{
	public class Libro
	{ 
		public string cod { get; set; }
		public string titulo { get; set; }

		public string autor { get; set; }

		public string disponible = "Disponible";
		public Libro(string _cod, string _titulo, string autor)
		{
			this.cod = _cod;
			this.titulo = _titulo;
			this.autor = autor;
			
		}
	}

}
