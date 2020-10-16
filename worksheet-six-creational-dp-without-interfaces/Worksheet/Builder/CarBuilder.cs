namespace QuestionTwo
{
    public abstract class CarBuilder
    {
        public abstract void BuildBodyStyle();

        public abstract void BuildPower();

        public abstract void BuildEngine();

        public abstract void BuildBreaks();

        public abstract void BuildSeats();

        public abstract void BuildWindows();

        public abstract void BuildFuelType();

        public abstract Car GetCar();
    }
}