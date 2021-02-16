using System;

namespace FIGURAS_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 1;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("¿Desea utilizar la aplicación para el cálculo del área de alguna figura? <S/N>");
                   string valor =  Console.ReadLine();
                   // if (valor=="S" || valor =="s")
                   if(valor.ToUpper()=="S")
                    {
                        Console.WriteLine("Elige la figura del área que desea calcular: \n" +
                                        "1. AREA DE UN CUADRADO \n" + "2. AREA DE UN RECTANGULO \n" + "3. AREA DE UN CIRCULO");
                        string opcion = Console.ReadLine();
                        FIGURAS fIGURAS = new FIGURAS(); //instanciando a la clase figuras
                        switch (opcion)
                        {
                            case "1": fIGURAS.areaCuadrado(); break;
                            case "2": fIGURAS.areaRectangulo(); break;
                            case "3": fIGURAS.areaCirculo(); break;
                            default:
                                Console.WriteLine("OPCION ELEGIDA NO VALIDA");
                                break;
                        }
                        n++;
                    }
                    else if(valor == "N" || valor== "n" ) //otra forma de comparar con el "or" "||"
                    {
                        return; //retorna a la función principal y se termina la ejecución en curso
                    }

                    
                }
                
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("La aplicación ha fallado. Contacte con su técnico. " + ex.Message);
               // throw;
            }
            
                
        }
    }
}
