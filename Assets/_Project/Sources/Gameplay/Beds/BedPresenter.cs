using UnityEngine;
using Sources.MVP;
using Zenject;
using Sources.Gameplay.Economy;

namespace Sources.Gameplay.Beds
{
    public class BedPresenter : Presenter
    {
        public BedPresenter(Model model) : base(model)
        {
        }

        public override void OnBedsSlotClicked(int slotId)
        {
            if(Model.TryBuyBed(slotId))
            {

                Debug.Log("Successfully bought a bed");
            }
        }
    }
}