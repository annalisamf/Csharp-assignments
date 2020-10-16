namespace QuestionTwo
{
    public class CarDirector : ICarDirector
    {
        private ICarBuilder _carBuilder = null;
        
        public CarDirector(ICarBuilder cb)
        {
            _carBuilder = cb;
        }


        public void Build()
        {
            _carBuilder.BuildPower();
            _carBuilder.BuildBreaks();
            _carBuilder.BuildEngine();
            _carBuilder.BuildSeats();
            _carBuilder.BuildWindows();
            _carBuilder.BuildFuelType();
            _carBuilder.BuildBodyStyle();
        }
    }
}