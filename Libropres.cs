using System;

public class Libropres
{
	public string cod { get; set; }
	public string titulo { get; set; }

	public string autor { get; set; }

	public string disponible = "Prestado";

	public string nombre { get; set; }

	public string doc { get; set; }

	public Libropres(string _cod, string _titulo, string _autor, string _nombre, string _doc)
	{
		this.cod = _cod;
		this.titulo = _titulo;
		this.autor = _autor;
		this.nombre = _nombre;
		this.doc = _doc;
	}
}
