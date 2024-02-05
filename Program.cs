namespace FechaEjercicio3
{

    class Program
    {

        static void Main(string[] args)
        {
            Random azar = new Random();
            int anyos = azar.Next(0, 4+1);

            DateTime dateTime = DateTime.Now;

            DateTime dateTime2 = dateTime.AddDays(1).AddMonths(24).AddYears(anyos);

            Console.WriteLine(dateTime2.ToString());
            
        }

    }

}