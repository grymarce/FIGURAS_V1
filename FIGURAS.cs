using System;
using System.Collections.Generic;
using System.Text;

namespace FIGURAS_V1
{
    class FIGURAS
    {
        // public decimal area
        //{ get; set;} //get  y set son de tipo lectura y escritura
        double area = 0;
        double lado = 0;
        double ancho = 0;
        double radio = 0;

        public void areaCuadrado()  //sintaxis: visibilidad seguido de tipo de valor a retornar, seguido del nombre de la funcion
        {
            Console.WriteLine("Escribe el lado: ");
          lado = Convert.ToDouble(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El resultado del area es: " + area);

        }
        public void areaRectangulo() 
        {
            Console.WriteLine("Escribe el largo: ");
            lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());
            area = lado * ancho;
            Console.WriteLine("El resultado del area es: " + area);
        }
        public void areaCirculo()
        {
            Console.WriteLine("Escribe el radio: ");
            radio = Convert.ToDouble(Console.ReadLine());
            area = Math.PI*Math.Pow(radio,2);
            Console.WriteLine("El resultado del area es: " + area);
        }


    }
}

//**************************Ingrid Centeno**************************