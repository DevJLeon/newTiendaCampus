using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiendaCampus.Entities;
public class Categoria
{
    private int id;
    private string description;
    public int Id {
        get { return this.id;}
        set { this.id = value;}
    }
    public string Description {
        get { return this.description;}
        set { this.description = value;}
    }

    public static void AddCategory (){
        Categoria cat = new Categoria();
        Console.Write("Ingrese el id de la categoria: ");
        cat.Id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre de la categoria: ");
        cat.Description = Console.ReadLine();
        Env.TiendaCampus.Categorias.Add(cat); //Repasar esto********** pq no entiendo XD
    }
    public IEnumerable<Categoria> ListaCategorias(){
        return from cat in Env.TiendaCampus.Categorias
    }
}
