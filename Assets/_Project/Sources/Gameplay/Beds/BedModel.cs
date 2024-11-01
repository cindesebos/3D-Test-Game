using System.Collections.Generic;
using System.Linq;
using Sources.Gameplay.Economy;
using Sources.MVP;

namespace Sources.Gameplay.Beds
{
    public class BedModel : Model
    {
        private List<bool> _availableSlots = new List<bool>();

        private readonly Bank _bank;
        private readonly BedsContainer _bedsContainer;

        public BedModel(View view, BedsContainer bedContainer, Bank bank) : base(view)
        {
            _bank = bank;
            _bedsContainer = bedContainer;

            for(int i=0; i<_bedsContainer.BedSlots.ToList().Count; i++) _availableSlots.Add(true);
        }

        public override bool TryBuyBed(int id)
        {
            int bedPrice = _bedsContainer.GetBedSlotById(id).PurchasePrice;

            if(_availableSlots[id] && _bank.Gold.TrySpend(bedPrice))
            {
                View.SetCarrotsBedMesh(id);

                _availableSlots[id] = false;

                return true;
            }

            return false;
        }
    }
}