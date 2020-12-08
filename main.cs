using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    int? num1 = null;
    int? num2 = 12345;
    double? num3 = null;
    double? num4 = 123.35;

    bool? valor = new bool?();

    Console.WriteLine("{0}, {1}, {2}, {3}", num1, num2, num3, num4);
    Console.WriteLine("El valor es '{0}'", valor); 

    //el null es usado cuando existen campos por ejemplo para llenado por parte de un usuario y en el caso que no se llene un campo especifico,
    //habria que tener un metodo que permite campos vacion como null
    bool? esHombre = null;
    if(esHombre == true) Console.WriteLine("El usuario es hombre");
    else if(esHombre == false) Console.WriteLine("El usuario es mujer");
    else Console.WriteLine("El usuario no especifico género");

    //ejm
    double? num5 = 13.31;
    double? num6 = null;
    double num7;

    if(num5 == null){
      num7 = 0.00;
    }else{
      num7 = (double)num5;
    }
    Console.WriteLine("El valor de num7 es: {0}", num7);

    //?? si es null
    num7 = num5 ?? 8.51;
    Console.WriteLine("Con esta sentencia si el valor de num5 es null se aplicara el valor de 8.51: {0}", num7);

    num7 = num6 ?? 8.51;
    Console.WriteLine("Con esta sentencia si el valor de num6 es null se aplicara el valor de 8.51: {0}", num7);
  }
}
