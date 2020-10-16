using System;
using System.Text;

namespace QuestionOne
{
    public static class TestAbstractFactoryPattern
    {
        private const string Divider = "*******************************";

        public static void Main(string[] args)
        {
            var parserFactory = ParserFactoryProducer.GetFactory("NYCFactory");
            var parser = parserFactory.GetParserInstance("NYCORDER");
            Console.WriteLine(parser.Parse());

            Console.WriteLine(Divider);

            parserFactory = ParserFactoryProducer.GetFactory("LondonFactory");
            parser = parserFactory.GetParserInstance("LONDONFEEDBACK");
            Console.WriteLine(parser.Parse());
        }
    }
}