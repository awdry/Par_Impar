//Usando los conocimientos adquiridos, usted debe desarrollar
//un programa que le solicite al usuario un numero y el
//programa indique si es par o impar.

bool continueprogram = true;
while (continueprogram)
{
   try{ 
Console.WriteLine("Ingrese un número: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("El numero es par.");
}
else{
    Console.WriteLine("El numero es impar.");
}
   }
   catch (FormatException)
    {
        Console.WriteLine("ERROR DEBE DE INGRESAR UN NúMEOR VALIDO");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocurrió un error: {ex.Message}");
    }

    Console.ReadKey();

}
