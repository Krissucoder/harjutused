using System.Numerics;

namespace Fileoperatison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Kirjuta siia oma postkasti aadress");
            //string filePath = "C:\\Users\\opilane\\source\\repos\\krön\\Konspekt_Kristofer-Thor-Kr--nstr-m_IKTPe-25-1\\korrdamisül\\programmerimis-lesanded\\harjutused\\FileOperatsion\\Fileoperatison\\postkastiaadress.txt";
            //string aadress = Console.ReadLine();

            //File.WriteAllText(filePath, aadress);

            Console.WriteLine("Kõik laulusõnad");

            //DisplayThisFile();

            FindWord("Billie");
        }
        public static void FindWord(string findThisWord)
        {
            using (StreamReader readFile = new StreamReader("C:\\Users\\opilane\\source\\repos\\krön\\Konspekt_Kristofer-Thor-Kr--nstr-m_IKTPe-25-1\\korrdamisül\\programmerimis-lesanded\\harjutused\\FileOperatsion\\Fileoperatison\\postkastiaadress.txt"))
            {
                int lnr = 0;
                while (readFile.EndOfStream == false)
            {
                    string line = readFile.ReadLine();
                    lnr++;

                    if (line.Contains(findThisWord) == true)
                    {
                        Console.WriteLine(findThisWord+" leiti reast "+lnr);
                    }
                     }
                readFile.Close();
                    
            }
        }


        private static void DisplayThisFile()
        {
            string line = "";
            try
            {
                using (StreamReader readThisThing = new StreamReader
                ("C:\\Users\\opilane\\source\\repos\\krön\\Konspekt_Kristofer-Thor-Kr--nstr-m_IKTPe-25-1\\korrdamisül\\programmerimis-lesanded\\harjutused\\FileOperatsion\\Fileoperatison\\postkastiaadress.txt"))
                {
                    int lineCount = 0;
                    while (readThisThing.EndOfStream == false)
                    {
                        lineCount++;
                        line = readThisThing.ReadLine();
                        int pikkus = line.Length;
                        Console.WriteLine(lineCount + " " + line + " . Reapikkus on " + pikkus);
                    }
                    readThisThing.Close();
                }
                
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Ei saa lugeda sest:"+e.Message);
                throw;
            }




        }
    }
}
