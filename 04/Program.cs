using System;

namespace _04
{

    
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. .doc 2. .txt 3. .xml");
                
                switch (Console.ReadLine())
                {
                    case "1":
                        DOCHandler doc = new DOCHandler();
                        doc.main();
                        break;
                    case "2":
                        TXTHandler txt = new TXTHandler();
                        txt.main();
                        break;
                    case "3":
                        XMLHandler xml = new XMLHandler();
                        xml.main();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }                        
        }
    }
}
