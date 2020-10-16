namespace QuestionOne
{
    public static partial class ParserFactoryProducer
    {
        public class LDNParserFactory : IAbstractParserFactory
        {
            public IXMLParser GetParserInstance(string parserType) => parserType switch
            {
                "LNDERROR" => new LDNErrorXMLParser(),
                "LDNFEEDBACK" => new LDNFeedbackXMLParser(),
                "LDNORDER" => new LDNOrderXMLParser(),
                "LDNRESPONSE" => new LDNResponseXMLParser(),
                _ => null
            };
        }
    }
}