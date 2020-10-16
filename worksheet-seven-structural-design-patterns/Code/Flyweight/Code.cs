namespace Flyweight
{
    public class Code
    {
        private string _code { get; set; }
        public Code(string code) => _code = code;

        public override string ToString()
        {
            return $"{_code}";
        }
    }
}