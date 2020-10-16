namespace interpreter
{
    public sealed class ExpressionUtils
    {
        public static bool IsOperator(string s)
        {
            return s.Equals("+") || s.Equals("*");
        }

        public static IExpression GetOperator(string s, IExpression left, IExpression right)
        {
            return s switch
            {
                "+" => (IExpression) new Add(left, right),
                "*" => new Product(left, right),
                _ => null
            };
        }
    }
}