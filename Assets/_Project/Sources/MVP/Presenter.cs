namespace Sources.MVP
{
    public abstract class Presenter
    {
        public readonly Model Model;

        public Presenter(Model model) => Model = model;

        public virtual void OnBedsSlotClicked(int slotId) {}
    }
}