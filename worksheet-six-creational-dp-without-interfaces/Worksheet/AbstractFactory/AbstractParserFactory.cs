namespace QuestionOne
{
    public abstract class AbstractParserFactory
    {
        public abstract XMLParser GetParserInstance(string parserType);
    }
}