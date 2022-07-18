using System.IO;
namespace KanciarzKonsola
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Praktykant\source\repos\LosowyZestawKartKonsolowa\TajnyPlik.txt");
            sw.WriteLine("W jai sposób pokonać kapitana wspaniałego?");
            sw.WriteLine("Kolejny genialny tajny plan kanciarza");
            sw.WriteLine("Stworzę armię klonów");
            sw.WriteLine("uwolnie je i wystawię rzeciwko mieszkańcom Obiektowa");
            string location = "centrum handlowe";
            for(int i = 0; i <= 6; i++)
            {
                sw.WriteLine("Klon {0} atakuje {1}", i, location);
                if(location =="centrum handlowe") { location = "centrum miasta"; }
                else { location = "centrum handlowe"; }
            }
            sw.Close();
        }
    }
}