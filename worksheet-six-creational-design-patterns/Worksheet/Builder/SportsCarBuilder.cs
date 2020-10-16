namespace QuestionTwo
{
    public class SportsCarBuilder : ICarBuilder
    {
        private readonly ICar _car = new SportCar("SEDAN");

        public void BuildBodyStyle() => _car.BodyStyle = "It has a sport body";
        public void BuildPower() => _car.Power = "It has a lot of power";
        public void BuildEngine() => _car.Engine = "It has a big engine";

        public void BuildBreaks() => _car.Brakes = "It has breaks";

        public void BuildSeats() => _car.Seats = "It has 2 seats";

        public void BuildWindows()=> _car.Windows= "It has strong windows";

        public void BuildFuelType() => _car.FuelType = "It is electric";

        class SportCar : Car
        {
            public SportCar(string carType) : base(carType)
            {
            }
        }

        public ICar GetCar() => _car;
    }
}