using R3;

namespace Sources.Gameplay.Economy
{
    public abstract class Currency<T>
    {
        public ReactiveProperty<T> Value = new ReactiveProperty<T>();

        public abstract bool TryAdd(T amount);
        public abstract bool TrySpend(T amount);
    }
}