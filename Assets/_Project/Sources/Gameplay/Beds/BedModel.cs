using System.Collections.Generic;
using System.Linq;
using Sources.MVP;
using UnityEngine;

namespace Sources.Gameplay.Beds
{
    public class BedModel : Model
    {
        private List<bool> _availableSlots = new List<bool>();

        public BedModel(View view, IEnumerable<BedSlot> bedSlots) : base(view)
        {
            for(int i=0; i<bedSlots.ToList().Count; i++) _availableSlots.Add(true);
        }

        public override bool TryBuyBed(int id)
        {
            if(_availableSlots[id])
            {
                View.SetCarrotsBedMesh(id);

                _availableSlots[id] = false;

                return true;
            }

            return false;
        }
    }
}