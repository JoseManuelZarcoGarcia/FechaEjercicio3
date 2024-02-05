namespace FechaEjercicio3
{

    class Program
    {

        static void Main(string[] args)
        {
            Random azar = new Random();
            int anyos = azar.Next(0, 4+1);

            DateTime dateTime = DateTime.Now;

            DateTime dateTime2 = dateTime.AddDays(1).AddMonths(-24).AddYears(anyos);

            Console.WriteLine(dateTime2.ToString());
            int comprobacion = dateTime2.CompareTo(dateTime);
            Console.WriteLine(comprobacion);


            if (comprobacion > 0)
            {
                Console.WriteLine("El hoy es más grande");
            }
            else
            {
                Console.WriteLine("escribe lo que quieras");
            }
            
        }

    }

}