using System;

namespace QuestionTwo
{
    public static class TestBuilderPattern
    {
        public static void Main(string[] args)
        {
            CarBuilder carBuilder = new SedanCarBuilder();
            CarDirector director = new CarDirector(carBuilder);
            director.Build();
            Console.WriteLine(carBuilder.GetCar());

            carBuilder = new SportsCarBuilder();
            director = new CarDirector(carBuilder);
            director.Build();
            Console.WriteLine(carBuilder.GetCar());
        }
    }
}