namespace worksheet_nine_behavioural_design_patterns
{
    public class Memento
    {
        public double X { get; }
        public double Y { get; }

        public Memento(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}