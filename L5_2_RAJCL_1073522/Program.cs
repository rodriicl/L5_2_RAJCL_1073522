int numeroEntero = 0;

Console.WriteLine("EJERCICIO 2");

Console.WriteLine("Numero de la semana");


numeroEntero = Convert.ToInt32(Console.ReadLine());


if (numeroEntero <= 0)
{
    Console.WriteLine("Error. El nùmero a ingresar debe estar contenido entre 1 y 7");

}
else if (numeroEntero > 7)
{
    Console.WriteLine("Error. El nùmero a ingresar debe estar contenido entre 1 y 7");
}
else if (numeroEntero == 1)
{
    Console.WriteLine("LUNES");
}
else if (numeroEntero == 2)
{
    Console.WriteLine("MARTES");
}
else if (numeroEntero == 3)
{
    Console.WriteLine("MIERCOLES");
}
else if (numeroEntero == 4)
{
    Console.WriteLine("JUEVES");
}
else if (numeroEntero == 5)
{
    Console.WriteLine("VIERNES");
}
else if (numeroEntero == 6)
{
    Console.WriteLine("SABADO");
}
else if (numeroEntero == 7)
{
    Console.WriteLine("DOMINGO");
}