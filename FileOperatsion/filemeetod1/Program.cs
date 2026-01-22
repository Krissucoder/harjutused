using System.Security.Cryptography.X509Certificates;

namespace filemeetod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             

            Programm küsib kasutajalt reahaval luuletuse ridu, küsitatakse 4 korda ja kontrollitakse kas asutaja on siestanud keelatud sõnu, keelatud sõnad ise asuvad loendis kui kasutaja on sisestanud keelatud sõna küsitatakse kogu rida kasutajalt uuesti
            kui küsimine on lõpenud küsitatkse kasutajalt filinime ja luuletus salvestatakse faili pärast selvestust kuvatakse kasutajale tagasi

            */
            Console.WriteLine("Sisesta oma luuletus, salvesta see faili ja vaata oma luuletus hiljem üle");
            int riduOlemas = 0;
            string olemasolevSisu = "";
            while (riduOlemas < 4)
            {
                Console.WriteLine("Luuletuse järgmise rea sisestuseks kirjuta midagi.");
                List<string> keelatudSõnad = new List<string>() { "fuck,tra,vittu" };

                string hetkesisestus = "";
                while (hetkesisestus == "")
                {
                    hetkesisestus = ReadAnswer();
                    foreach (var ks in keelatudSõnad)
                    {
                        if (hetkesisestus.Contains(ks))
                        {
                            hetkesisestus = "";
                            Console.WriteLine("On leitud keelatud sõna, sisestus on tühistatud.");
                        }

                        olemasolevSisu += hetkesisestus;
                        riduOlemas++;
                    }
                }
                    Console.WriteLine("Sisesta failinimi kuhu soovid oma luuletuse salvestada:");
                    string failinimi = ReadAnswer();
                    string filePath = "C:\\Users\\opilane\\source\\repos\\krön\\Konspekt_Kristofer-Thor-Kr--nstr-m_IKTPe-25-1\\korrdamisül\\programmerimis-lesanded\\harjutused\\FileOperatsion\\filemeetod1\\" + failinimi+".txt";

                    File.WriteAllText(filePath, olemasolevSisu);
                    DisplayLuuletus(filePath);

            }
        }
        public static void DisplayLuuletus(string location)
        {
            using (StreamReader readLuuletus = new StreamReader(location))
            {
                while (readLuuletus.EndOfStream == false)
                {
                    Console.WriteLine(readLuuletus.ReadLine());
                }
                readLuuletus.Close();
            }
           
        }



        public static string ReadAnswer()
        {
            string vastus = "";
            while (vastus == "")
            {
                Console.WriteLine("Tee vastav sisestus:");
                vastus = Console.ReadLine();
            }
            return vastus;
        }
    }
}
