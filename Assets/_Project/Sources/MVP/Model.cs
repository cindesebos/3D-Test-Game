namespace Sources.MVP
{
    public abstract class Model
    {
        public readonly View View;

        public Model(View view) => View = view;

        public virtual bool TryBuyBed(int id) => false;
    }
}