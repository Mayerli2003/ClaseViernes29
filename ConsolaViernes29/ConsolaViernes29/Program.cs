using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaViernes29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(BarDbEntities db = new BarDbEntities())
            {
                //Insertar productos
                //Producto oProducto = new Producto();

                //Console.WriteLine(" Ingrese el Nombre");
                //oProducto.nomProd = Console.ReadLine();
                //Console.WriteLine("Ingrese la descripción");
                //oProducto.descripcion = Console.ReadLine();
                //Console.WriteLine("Ingrece el precio");
                //oProducto.precio = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Ingrese la cantidad");
                //oProducto.cantidad = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Ingrese el estado");
                //oProducto.estado = Convert.ToInt32(Console.ReadLine());

                

                //oProducto.nomProd = "Trenzuda";
                //oProducto.descripcion= "Medio litro";
                //oProducto.precio = 20;
                //oProducto.cantidad = 50;
                //oProducto.estado = 1;

                //db.Producto.Add(oProducto);
                //db.SaveChanges();

                //Actualizar
                Producto oProducto = db.Producto.Find(1);
                oProducto.nomProd = "Cubatass";
                db.Entry(oProducto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


                var lst = db.Producto;
                foreach (var oProductos in lst)
                {
                    Console.WriteLine(oProductos.nomProd);
                    //Console.WriteLine(oProductos.idProducto);
                }
                Console.WriteLine("Presione una tecla para continuar");
                Console.Read();
            }
        }
    }
}
