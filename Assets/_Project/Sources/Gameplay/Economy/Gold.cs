namespace Sources.Gameplay.Economy
{
    public class Gold : Currency<int>
    {
        public Gold() => Value.Value = 1300;

        public override bool TryAdd(int amount)
        {
            if(amount < 0) return false;

            Value.Value += amount;

            return true;
        }

        public override bool TrySpend(int amount)
        {
            if(amount < 0 || amount > Value.Value) return false;

            Value.Value -= amount;

            return true;
        }
    }
}