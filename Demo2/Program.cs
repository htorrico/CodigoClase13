//1.Ingresar Valor1 y Valor2 por pantalla
//2.Controlar excepcion de solo números
//3.Controlar excepción de divisón entre cero 
//4.Controlar excepción en la resta, el segundo número (Personalizada)
//no puede ser mayor que el primero


using Demo2;
using System.Text;

void WriteLog(string message) { }


void LlamarOperaciones()
{
    Operaciones operacion = null;
    StringBuilder stringBuilder = null;//Ejemplo para usar el finally

    try
    {
        stringBuilder = new StringBuilder();
        operacion = new Operaciones();
        

        Console.Write("Ingresa Valor1 ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa Valor2 ");
        int valor2 = int.Parse(Console.ReadLine());

        operacion.AsignarValores(valor1, valor2);

        Console.WriteLine("La Suma es:");
        Console.WriteLine(operacion.Sumar());

        Console.WriteLine("La Resta es:");
        Console.WriteLine(operacion.Restar());

        Console.WriteLine("La Division es:");
        Console.WriteLine(operacion.Dividir());
     
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Error: El valor ingresado no es un número válido.");
        WriteLog(ex.Message);
   
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Error: La división entre cero no es posible.");
        WriteLog(ex.Message);
      
    }
    catch (InvalidRestarExcepcion ex)
    {
        Console.WriteLine(ex.Message);
        WriteLog(ex.Message);
    
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error, por favor contactarse con el administrador");
        WriteLog(ex.Message);    
    }
    finally
    {
        //Limpias los objetos de memoria
        //Cierras las cadenas de conexión
        //Cierras las llamadas a las API
        //Cierras la lectura de archivos

        operacion = null;
        stringBuilder = null;
       
    }
}




LlamarOperaciones();