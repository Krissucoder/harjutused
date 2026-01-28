namespace TingimuslauseTöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere mis on sinu nimi");
            string nimi = "";
            nimi += Console.ReadLine();
            if (nimi != "nipitiri")
            {
                Console.WriteLine("Sa pole nipitiri ma ainult ootan Nipitirit");
            }
            Console.WriteLine("Tere kasutaja kas sulle meeldivad tulbid");
            string tulbid = "";
            tulbid = Console.ReadLine();
            if (tulbid != "")
            {
                Console.WriteLine("mulle kaaaaa");
            }
            else
            {
                Console.WriteLine("vabadust ma ei saa sinust aru");
            }
            Console.WriteLine("Kui palju tunde oled sa see nädal mänginud");
            int tunnid = 0;
            tunnid = int.Parse(Console.ReadLine());
            if (tunnid == 0)
            {
                Console.WriteLine("Kahju sul aega pole mängida");
            }
            else if (tunnid < 10 && tunnid > 0)
            {
                Console.WriteLine("Mõõdukas mängja oled");
            }
            else if (tunnid < 20 && tunnid > 10)
            {
                Console.WriteLine("Natuke paljuks läheb kodutõõd kannatvad");
            }
            else if (tunnid < 40 && tunnid > 20)
            {
                Console.WriteLine("Liiga palju mängid kas sa kooli üldse nii jõuad");
            }
            else if (tunnid < 40)
            {
                Console.WriteLine("Siin peaks juba psüholoog sekkuma");
            }

            int jalgpallimäng = 0;
            Console.WriteLine("Milline oli sinu viiamne jalgpalli tulemus");
            jalgpallimäng = int.Parse(Console.ReadLine());
            switch (jalgpallimäng)
            {
                case 0:
                    Console.WriteLine("pudrujalg oled vä!?!");
                    break;
                case 1:
                    Console.WriteLine("täitsa ok");
                    break;
                case 2:
                    Console.WriteLine("no see juba on parem");
                    break;
                case 3:
                    Console.WriteLine("Wow messi!");
                    break;
                case 4:
                    Console.WriteLine("ei tunne sellist skoori see liiga suur minu joaks");
                    break;
                    {

                    }
                    
                  






            }
        }
    }
}

 
