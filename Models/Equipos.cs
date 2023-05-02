public static class Equipos
{
    public static List<string> ListaEquipos {get; private set;} = new List<string>(){"River", "Boca", "Huracan", "Ferro", "San Lorenzo", "Racing", "Estudiantes de La Plata", "Independiente", "Belgrano", "Talleres"};
    public static List<string> ListaMedias {get; private set;} = new List<string>(){}
    public static List<string> ListaPantalones {get; private set;}
    public static List<string> ListaRemeras {get; private set;}
    public static Dictionary<string, Indumentaria> EquiposIndumentaria {get; private set;}

    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item)
    {
        foreach(string valor in EquiposIndumentaria.Keys)
        {
            if(valor != EquipoSeleccionado)
            {
                return true;
            }
        }
        return false;
    }
}