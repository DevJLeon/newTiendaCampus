using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tiendaCampus.Entities;
public class Producto
{
    private string idProducto;
    private string nombreProducto;
    private int stock;
    private int stockMin;
    private int stockMax;
    private double valorVenta;
    private double valorCompra;
    private int idCategoria;

    public Producto()
    {
        if(File.Exists(Env.FileName)){
            File.WriteAllText(Env.FileName, "");
        }
    }
}
