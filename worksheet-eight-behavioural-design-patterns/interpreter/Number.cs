namespace interpreter
{
    public class Number : IExpression
    {
        private int N { get; set; }

        internal Number(int n) => N = n;

        public int Interpret() => N;
    }
}