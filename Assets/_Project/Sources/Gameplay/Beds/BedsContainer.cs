using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sources.Gameplay.Beds
{
    public class BedsContainer : MonoBehaviour
    {
        [SerializeField] private List<BedSlot> _bedSlots = new List<BedSlot>();

        public IEnumerable<BedSlot> BedSlots => _bedSlots;

        private List<Bed> _beds = new List<Bed>();

        public IEnumerable<Bed> Beds => _beds;

        private void Update() => UpdateBeds();

        public void InitBedSlots(BedData data)
        {
            for(int id=0; id<_bedSlots.Count; id++) _bedSlots[id].Init(id, data);
        }

        public BedSlot GetBedSlotById(int id)
        {
            if (id < 0 || id >= _bedSlots.Count) return null;

            return BedSlots.ElementAt(id);
        }

        public void AddBed(Bed bed)
        {
            if(bed == null || _beds.Contains(bed)) return;

            _beds.Add(bed);
        }

        private void UpdateBeds()
        {
            if(_beds.Count > 0) foreach(Bed bed in _beds) bed.OnUpdate();
        }
    }
}