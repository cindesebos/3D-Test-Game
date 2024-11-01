namespace Sources.Gameplay.Economy
{
    public class Bank
    {
        public Gold Gold { get; private set; } = new Gold();
        public Carrot Carrot { get; private set; } = new Carrot();
    }
}