namespace interpreter
{
    public class Product : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public Product(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public int Interpret() => leftExpression.Interpret() * rightExpression.Interpret();
    }
}