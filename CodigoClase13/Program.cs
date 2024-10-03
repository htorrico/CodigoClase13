using CodigoClase13;

void DividirSinValidacion(string valor1, string valor2)
{
       double resultado;
        resultado = int.Parse(valor1) / int.Parse(valor2);
        Console.WriteLine(resultado);    
}
void Dividir(string valor1, string valor2)
{
    
    double resultado;    

    if (  int.Parse( valor2) == 0)
    {
        Console.WriteLine("No se puede dividir entre 0");
    }
    else
    {
        resultado = int.Parse( valor1) / int.Parse(valor2);

        Console.WriteLine(resultado);
    }

}
void MostrarDatoArreglo()
{
    int[] array = { 1, 2, 3 };

    int n = 2;


    if (n > array.Length)
    {
        Console.WriteLine("Ingrese un índice válido");
    }
    else
    {
        Console.WriteLine(array[n]);
    }

}
void WriteLog(string messsage){
    //
}
void Dividir2(string valor1, string valor2)
{
   

    try
    {
        double resultado;

        resultado = int.Parse(valor1) / int.Parse(valor2);

        Console.WriteLine(resultado);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error, por favor contactarse con el administrador");
        WriteLog(ex.Message);
    }

}
void Dividir3(string valor1, string valor2)
{

    try
    {
        double resultado;

        resultado = int.Parse(valor1) / int.Parse(valor2);
        Console.WriteLine(resultado);
    }
    catch (DivideByZeroException ex)
    {

        Console.WriteLine("Por favor no se puede dividir entre cero");
        WriteLog(ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Por favor ingrese un número válido");
        WriteLog(ex.Message);
    }

    catch (Exception ex)
    {
        Console.WriteLine("Error, por favor contactarse con el administrador");
        WriteLog(ex.Message);
    }


}
void ValidarArreglo()
{

    //Una declaración no va generar expceción
    int[] numeros = { 10, 20, 30, 40, 50 };



    Console.Write("Ingresa un índice (0-4): ");
    try
    {             
        //Una conversión, si es posible que genere una excepción
        int indice = int.Parse(Console.ReadLine());
        Console.WriteLine(numeros[indice]);    
    }
    
    catch (IndexOutOfRangeException ex)
    {
        WriteLog(ex.Message);
        Console.WriteLine("Error: El índice ingresado está fuera del rango permitido (0-4).");
    }
    catch (FormatException ex )
    {
        WriteLog(ex.Message);
        Console.WriteLine("Error: Debes ingresar un número.");
    }
    catch (Exception ex)
    {
        WriteLog(ex.Message);
        Console.WriteLine("Error: Debes comunicarte con el administrador");
    }





}

void Personalizado()
{
    try
    {
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 0 || edad > 120)
        {
        throw new InvalidAgeException("La edad ingresada no es válida. Debe estar entre 0 y 120.");       
        }

        Console.WriteLine($"Tu edad es: {edad}");
    }
    catch (InvalidAgeException ex)
    {
        Console.WriteLine($"error: {ex.Message}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Error: El valor ingresado no es un número válido.");
        WriteLog(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error, por favor contactarse con el administrador");
        WriteLog(ex.Message);
    }

}
void PersonalizadoNotas()
{
    try
    {
        Console.Write("Ingresa tu nota: ");
        int nota = int.Parse(Console.ReadLine());
        if (nota < 0 || nota > 20)
        {
            throw new InvalidNoteExcepcion();
        }
        Console.WriteLine($"Tu edad es: {nota}");
    }
    catch (InvalidNoteExcepcion ex)
    {
        Console.WriteLine($"error: {ex.Message}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Error: El valor ingresado no es un número válido.");
        WriteLog(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error, por favor contactarse con el administrador");
        WriteLog(ex.Message);
    }

}

void PersonalizadoCompleto()
{
    try
    {
        throw new InvalidAgeException("La edad ingresada no es válida. Debe estar entre 0 y 120.");
        throw new InvalidNoteExcepcion();
    }
    catch (Exception)
    {

        throw;
    }
}




//PersonalizadoNotas();
//DividirSinValidacion("10", "abc");
//Dividir3("10", "0");
//Dividir3("10", "ABC");
//ValidarArreglo();
//Personalizado();




Console.Read();
