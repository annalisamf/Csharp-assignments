using System;
using System.Text;

namespace QuestionOne
{
    public static class TestAbstractFactoryPattern
    {
        private const string Divider = "*******************************";

        public static void Main(string[] args)
        {
            IAbstractParserFactory parserFactory = ParserFactoryProducer.GetFactory("NYCFactory");
            IXMLParser parser = parserFactory.GetParserInstance("NYCORDER");
            Console.WriteLine(parser.Parse());

            Console.WriteLine(Divider);
            
            parserFactory = ParserFactoryProducer.GetFactory("LDNFactory");
            parser = parserFactory.GetParserInstance("LDNFEEDBACK");
            Console.WriteLine(parser.Parse());
        }
    }
}