namespace mediator
{
    public class Machine : IColleague
    {
        public IMachineMediator Mediator { get; set; }

        public void Start() => Mediator.Open();
        public void Wash() => Mediator.Wash();
    }
}