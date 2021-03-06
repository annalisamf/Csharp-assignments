using System;

namespace QuestionOne
{
    public class NYCParserFactory : IAbstractParserFactory
    {
        public IXMLParser GetParserInstance(string parserType) => parserType switch
        {
            "NYCERROR" => new NYCErrorXMLParser(),
            "NYCFEEDBACK" => new NYCFeedbackXMLParser(),
            "NYCORDER" => new NYCOrderXMLParser(),
            "NYCRESPONSE" => new NYCResponseXMLParser(),
            _ => null
        };
    }
}