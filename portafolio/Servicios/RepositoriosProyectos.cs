using System;
using portafolio.Models;

namespace portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
	public class RepositorioProyectos : IRepositorioProyectos
	{
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
            new Proyecto
        {
            Titulo = "Amazon",
            Descripcion = "Sitio Wep Responsivo en ASP.NET Core",
            Link = "https://amazon.com",
            ImagenURL = "/imagenes/amazon.png"
        },
             new Proyecto
        {
            Titulo = "Ebay",
            Descripcion = "Redes sociales para comunidad",
            Link = "https://nytimes.com",
            ImagenURL = "/imagenes/nyt.png"
        },
              new Proyecto
        {
            Titulo = "Coopealianza",
            Descripcion = "Tienda en Linea",
            Link = "https://coopealianza.com",
            ImagenURL = "/imagenes/reddit.png"
        },
        };
        }
    }
}

