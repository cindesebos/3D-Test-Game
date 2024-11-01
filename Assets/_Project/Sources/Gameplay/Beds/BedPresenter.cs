using UnityEngine;
using Sources.MVP;
using Zenject;
using Sources.Gameplay.Economy;
using Sources.Gameplay.BedsCreator;

namespace Sources.Gameplay.Beds
{
    public class BedPresenter : Presenter
    {
        private ICreator _creator;

        public BedPresenter(Model model, ICreator creator) : base(model)
        {
            _creator = creator;
        }

        public override void OnBedsSlotClicked(int slotId)
        {
            if(Model.TryBuyBed(slotId))
            {
                CarrotBed carrotBed = _creator.CreateCarrotBed();

                carrotBed.StartWork();

                Debug.Log("Successfully bought a bed");
            }
        }
    }
}