using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sources.Gameplay.Beds
{
    public class BedContainer : MonoBehaviour
    {
        [SerializeField] private List<BedSlot> _bedSlots = new List<BedSlot>();

        public IEnumerable<BedSlot> BedSlots => _bedSlots;

        public void InitBedSlots(BedData data)
        {
            for(int id=0; id<_bedSlots.Count; id++) _bedSlots[id].Init(id, data);
        }

        public BedSlot GetBedSlotById(int id)
        {
            if (id < 0 || id >= _bedSlots.Count) return null;

            return BedSlots.ElementAt(id);
        }
    }
}