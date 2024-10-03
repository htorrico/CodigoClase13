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


void WriteLog(string messsage)
{
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


//DividirSinValidacion("10", "abc");
Dividir3("10", "0");
Dividir3("10", "ABC");


Console.Read();
