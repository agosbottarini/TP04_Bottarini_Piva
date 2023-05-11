using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP04_Bottarini_Piva.Models
{
    public static class Equipos
{
    public static List<string> ListaEquipos {get; private set;} = new List<string>(){"River ", " Boca ", "Huracan ", "Ferro ", "San Lorenzo ", "Racing ", "Estudiantes de La Plata ", "Independiente ", "Belgrano ", "Talleres"};
    public static List<string> ListaMedias {get; private set;} = new List<string>(){"medias_amarillas.jpg", "medias_azules.jpg", "medias_blancas.jpg", "medias_celestes.jpg", "medias_grises.jpg", "medias_naranjas.jpg", "medias_negras.jpg", "medias_rojas.jpg", "medias_verdes.jpg", "medias_violetas.jpg"};
    public static List<string> ListaPantalones {get; private set;} = new List<string>(){"pantalon_amarillo.jpg", "pantalon_azul.jpg", "pantalon_blanco.jpg", "pantalon_celeste.jpg", "pantalon_grises.jpg", "pantalon_naranja.jpg", "pantalon_negro.jpg", "pantalon_rojo.jpg", "pantalon_verde.jpg", "pantalon_violeta.jpg"};
    public static List<string> ListaCamisetas {get; private set;} = new List<string>(){"camiseta_amarilla.jpg", "camiseta_azul.jpg", "camiseta_blanca.jpg", "camiseta_celeste.jpg", "camiseta_gris.jpg", "camiseta_naranja.jpg", "camiseta_negra.jpg", "camiseta_roja.jpg", "camiseta_verde.jpg", "camiseta_violeta.jpg"};
    public static Dictionary<string, Indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary<string, Indumentaria>();

    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item)
    {
        foreach(string valor in EquiposIndumentaria.Keys)
        {
            if(valor != EquipoSeleccionado)
            {
                EquiposIndumentaria.Add(EquipoSeleccionado,item);
                return true;
            }
        }
        return false;
    }
}

}
