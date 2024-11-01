namespace Sources.Gameplay.Economy
{
    public class Carrot : Currency<int>
    {
        public Carrot() => Value.Value = 0;

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