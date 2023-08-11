using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiendaCampus.View;
public class MenusView
{
    public static int MenuPrincipal(){
        Console.Clear();
        Console.WriteLine("1. Registro de productos");
        Console.WriteLine("2. Registro de categorias");
        Console.WriteLine("3. Salir");
        return int.Parse(Console.ReadLine());
    }
}
