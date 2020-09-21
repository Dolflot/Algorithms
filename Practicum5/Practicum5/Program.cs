using System;

namespace Alg1.Practica.Practicum5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            XmlValidator xml = new XmlValidator();

            string test1 = "<sarcasm> Het komt<em> vast</em> goed </sarcasm>";
            string test2 = "<sarcasm><em>Het komt vast goed</sarcasm></em>";
            string test3 = "<sarcasm > Het komt<em> vast</em> goed </sarcasm>";

            bool one = xml.Validate(test1);
            bool two = xml.Validate(test2);
            bool three = xml.Validate(test3);

            Console.WriteLine("test1: " + one + " test2: " + two + " test3: " + three);
            Console.ReadLine();
        }
    }
}
