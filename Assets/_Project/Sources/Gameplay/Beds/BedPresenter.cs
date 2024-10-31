using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading.Tasks;
using Sources.MVP;

namespace Sources.Gameplay.Beds
{
    public class BedPresenter : Presenter
    {
        public BedPresenter(Model model) : base(model) {}

        public override void OnBedsSlotClicked(int slotId)
        {
            if(Model.TryBuyBed(slotId))
            {
                Debug.Log("Successfully bought a bed");
            }
        }
    }
}