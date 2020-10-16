namespace QuestionTwo
{
    public class SedanCarBuilder : ICarBuilder
    {
        private readonly ICar _car = new SedanCar("SEDAN");

        public void BuildBodyStyle() => _car.BodyStyle = "It has one";
        public void BuildPower() => _car.Power = "It has power";
        public void BuildEngine() => _car.Engine = "It has a medium engine";

        public void BuildBreaks() => _car.Brakes = "It has breaks";

        public void BuildSeats() => _car.Seats = "It has 5 seats";

        public void BuildWindows()=> _car.Windows= "It has some windows";

        public void BuildFuelType() => _car.FuelType = "It uses petrol";

        class SedanCar : Car
        {
            public SedanCar(string carType) : base(carType)
            {
            }
        }

        public ICar GetCar() => _car;
    }
}