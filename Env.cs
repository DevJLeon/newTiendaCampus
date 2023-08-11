using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tiendaCampus.Entities;

namespace tiendaCampus;
public static class Env
{
    private static string fileName = "tiendaCampus.Json";
    private static TiendaCampus tiendacampus = new TiendaCampus();
    /**/

    public static string FileName {get=>fileName; set => fileName = value;}

    public static TiendaCampus TiendaCampus {get => tiendacampus; set => tiendacampus = value;}

    public static void LoadDataProductos(string nombreArchivo){
        using (StreamReader reader = new StreamReader(nombreArchivo))
        {
            string json = reader.ReadToEnd();
            Env.TiendaCampus = System.Text.Json.JsonSerializer.Deserialize<TiendaCampus>(json, new System.Text.Json.JsonSerializerOptions() {PropertyNameCaseInsensitive= true}) ?? new TiendaCampus;
        }
    }
}
