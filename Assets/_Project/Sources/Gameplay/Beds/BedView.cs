using UnityEngine;
using Sources.MVP;
using System.Collections.Generic;
using System.Linq;

namespace Sources.Gameplay.Beds
{
    public class BedView : View
    {
        private List<BedSlot> _bedSlots;
        private BedData _data;
        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
        }

        public void Init(Presenter presenter, IEnumerable<BedSlot> bedSlots, BedData data)
        {
            Presenter = presenter;
            _bedSlots = bedSlots.ToList();
            _data = data;
        }

        public void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                HandleInput();
            }
        }

        public void HandleInput()
        {
            RaycastHit hit;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.TryGetComponent(out BedSlot slot))
                {
                    Presenter.OnBedsSlotClicked(slot.Id);
                }
            }
        }

        public override void SetCarrotsBedMesh(int id)
        {
            _bedSlots[id].GetComponentInChildren<MeshFilter>().mesh = _data.СarrotsBedMesh;
        }
    }
}