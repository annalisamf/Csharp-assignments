using System.Linq.Expressions;

namespace interpreter
{
    public class Add : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public Add(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public int Interpret() => leftExpression.Interpret() + rightExpression.Interpret();
    }
}