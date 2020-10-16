namespace QuestionTwo
{
    public class CarDirector
    {
        private CarBuilder _carBuilder = null;
        public CarDirector(CarBuilder cb)
        {
            _carBuilder = cb;
        }

        public void Build()
        {
            _carBuilder.BuildBodyStyle();
            _carBuilder.BuildPower();
                // ...
        }
    }
}