using UnityEngine;
using Sources.MVP;
using System.Collections.Generic;
using System.Linq;

namespace Sources.Gameplay.Beds
{
    public class BedView : View
    {
        private BedContainer _bedContainer;
        private BedData _data;
        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
        }

        public void Init(Presenter presenter, BedContainer bedContainer, BedData data)
        {
            Presenter = presenter;
            _bedContainer = bedContainer;
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
                if (hit.collider.TryGetComponent(out BedSlot bedSlot))
                {
                    Presenter.OnBedsSlotClicked(bedSlot.Id);
                }
            }
        }

        public override void SetCarrotsBedMesh(int id)
        {
            _bedContainer.GetBedSlotById(id).GetComponentInChildren<MeshFilter>().mesh = _data.СarrotsBedMesh;
        }
    }
}