using System.IO;
namespace KapitanKonsolowaOdczyt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StreamReader reader = new StreamReader(@"C:\Users\Praktykant\source\repos\LosowyZestawKartKonsolowa\TajnyPlik.txt");
            StreamWriter writer = new StreamWriter(@"C:\Users\Praktykant\source\repos\KapitanKonsolowaOdczyt\emaildDoKapitana.txt");

            writer.WriteLine("To: KapitanWspaniały");
            writer.WriteLine("From: Komisarz");
            writer.WriteLine("Subjec: Czy pomożesz ocalić świat?");
            writer.WriteLine();
            writer.WriteLine("Odkrliśmy plan kanciarza.");
            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("Plan ->" + lineFromThePlan);
            }
            writer.WriteLine();
            writer.WriteLine("Możesz nam pomóc?");
            writer.Close();
            reader.Close();
        }
    }
}