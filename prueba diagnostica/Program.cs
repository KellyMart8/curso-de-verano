using prueba_diagnostica;

Class1 c = new Class1();

do
{
    Console.WriteLine("Ingrese la canridad de empleados");
    c.CEmpleado = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 0; i < c.CEmpleado; i++)
    {

        Console.WriteLine("El empleado " + (i+1) + ". Ingrese su saldo");
        c.Salario = Convert.ToInt32(Console.ReadLine());

        do
        {
            //Console.WriteLine("El salario es:" + c.Salario);
            Console.WriteLine("El inss patronal es: " + c.InssP());
            Console.WriteLine("El inss laboral es: " + c.InssL());
        } while (c.Salario < 4799 && c.Salario >= 50000);

    }

} while (c.CEmpleado > 0 || c.CEmpleado <= 10);