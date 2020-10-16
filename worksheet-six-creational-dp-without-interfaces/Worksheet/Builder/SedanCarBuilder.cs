namespace QuestionTwo
{
    public class SedanCarBuilder : CarBuilder
    {
        private Car _car = new SedanCar("SEDAN");

        public override void BuildBodyStyle() => _car.BodyStyle = "It has one";
        
        public override void BuildPower() => _car.Power = "It has power";

        
        public override void BuildEngine()
        {
            throw new System.NotImplementedException();
        }

        public override void BuildBreaks()
        {
            throw new System.NotImplementedException();
        }

        public override void BuildSeats()
        {
            throw new System.NotImplementedException();
        }

        public override void BuildWindows()
        {
            throw new System.NotImplementedException();
        }

        public override void BuildFuelType()
        {
            throw new System.NotImplementedException();
        }

        public override Car GetCar() => _car;

        // the following can be avoided by using an interface
        class SedanCar : Car
        {
            public SedanCar(string type) : base(type)
            {
            }
        }
    }
}