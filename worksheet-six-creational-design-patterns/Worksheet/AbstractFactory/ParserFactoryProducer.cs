namespace QuestionOne
{
    public static partial class ParserFactoryProducer
    {
        public static IAbstractParserFactory GetFactory(string placeFactory) => placeFactory switch
        {
            "NYCFactory" => new NYCParserFactory(),
            "LDNFactory" => new LDNParserFactory(),
            _ => null
        };
    }
}