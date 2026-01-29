namespace Meetodid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string vastus = "";
            {

            }
            //kasutajalt info saamine
            Console.WriteLine("Palun sisesta filteeritav lähteinfo: ");
            string info = GetResponse();
            Console.WriteLine("Palun sisesta otsitav info: ");
            string searchThisWord = GetResponse();

            //filteerimine ja teavitus
            bool doesWordExist = FindThisWord(searchThisWord, info);
            if (doesWordExist == true)
            {
                Console.WriteLine("Leidsime sõna \"" + searchThisWord + "\" sinu sisestatud infost");
                Console.WriteLine(info);
            }
            else
            {
                Console.WriteLine("sõna \"" + searchThisWord + "\" infost puudub");
            }
            //programmi töö kordamine
            Console.WriteLine("Kas tahad tegevust korrata?");
            vastus = GetResponse();
            while (vastus == "jah") ;



            do
            {
                Console.WriteLine("kas soovid infosse midagi juurde lisada?");


            } while (vastus == "jah");

            // programmi lõpp
            Console.WriteLine("Headaega");

        }
        public static bool FindThisWord(string filter, string toBeFiltered)
        {
            if(toBeFiltered.Contains(filter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string  GetResponse()
        {
            string sisestus = "";
            while (sisestus == "")
            {
                sisestus = Console.ReadLine();
            }
            return "";

        }
    }
}
