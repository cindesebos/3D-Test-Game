using Sources.Gameplay.Beds;
using Sources.MVP;
using UnityEngine;
using System.Collections.Generic;

namespace Sources.Gameplay
{
    public class GameplayEntryPoint : MonoBehaviour
    {
        [SerializeField] private BedView _bedView;
        [SerializeField] private BedData _bedData;
        [SerializeField] private List<BedSlot> _bedSlots = new List<BedSlot>();

        public IEnumerable<BedSlot> BedSlots => _bedSlots;
        
        private void Awake()
        {
            BedModel bedModel = new BedModel(_bedView, BedSlots);
            BedPresenter bedPresenter = new BedPresenter(bedModel);
            _bedView.Init(bedPresenter, BedSlots, _bedData);
        }
    }
}