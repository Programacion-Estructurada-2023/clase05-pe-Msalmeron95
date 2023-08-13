using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaracion de variables

            //Declaracion de variables de tipo texto con captura desde conosla

            string? universidad="";   

            //Declarar 2 variables de tipo texto con asignacion desde codigo.

            string facultad="Ingenieria y Arquitectura"; 
            string profesion="Ingeniero en Desarrollo de Software";

            //Declaracion de variables int con captura desde consola

            int anioIngreso=0; 

            //Declaracion de variables int asignando valores
            int edadIngreso=28;
            int edadEgreso=33;

            //Declaracion de variables double asignando valor desde consola

            decimal cuotaUniversidad=0; 

            //Declaracion de varibales decimales asignando valores

            double gastoTransporte=40.00; 

            //CAPTURA DE DATOS DESDE CONSOLA

            Console.WriteLine("\n**************************************************");
            Console.WriteLine("\n-----Capturando datos de tipo texto -----");
            Console.WriteLine("Ingrese el nombre de la universidad donde estudia >> ");
            universidad=Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n-----Fin de captura de tipo texto -----\n");

            Console.WriteLine("\n-----Capturando datos de tipo enteros -----\n");
            Console.WriteLine("Ingrese el año que inicio la universidad >> ");
            anioIngreso=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n-----Fin de captura de tipo enteros -----\n");

            Console.WriteLine("\n-----Capturando datos de tipo decimal-----\n");
            Console.WriteLine("Ingrese la couta de la universidad >> ");
            cuotaUniversidad=Convert.ToDecimal(Console.ReadLine());  
            Console.WriteLine("\n-----Fin de captura de tipo decimal-----");
            Console.WriteLine("\n**************************************************");

            //IMPRESION DE DATOS EN CONSOLA
            Console.WriteLine("\n**************************************************\n\n");
            Console.WriteLine("\n----IMPRESION DE DATOS DE TIPO TEXTO -----"); 
            Console.WriteLine("\n La uniersidad en la que estudia es >> " + universidad);
            Console.WriteLine("\n Pertencece a la facultada de >> " + facultad);
            Console.WriteLine("\n Estudiando la carrera de >> " + profesion);
            Console.WriteLine("\n**************************************************\n");

            Console.WriteLine("\n**************************************************\n\n");
            Console.WriteLine("\n----IMPRESION DE DATOS ENTEROS -----"); 
            Console.WriteLine("\n El año que ingreso a la universidad fue >> " + anioIngreso);
            Console.WriteLine("\n La edad cuando inicio sus estudios es >> " + edadIngreso +" años");
            Console.WriteLine("\n La edad cuando finalice sus estudios sera >> " + edadEgreso +" años");
            Console.WriteLine("\n**************************************************\n");

            Console.WriteLine("\n**************************************************\n\n");
            Console.WriteLine("\n----IMPRESION DE DATOS DOUBLE -----"); 
            Console.WriteLine("\n La cuota de su universidad es >> " +"$"+ cuotaUniversidad);
            Console.WriteLine("\n Su  gasto en transporte es >> " +"$"+ gastoTransporte);
            Console.WriteLine("\n**************************************************\n");

            Console.ReadKey();
        }
    }
}