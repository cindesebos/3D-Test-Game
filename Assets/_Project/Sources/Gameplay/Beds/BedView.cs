using UnityEngine;
using Sources.MVP;

namespace Sources.Gameplay.Beds
{
    public class BedView : View
    {
        private BedsContainer _bedsContainer;
        private BedData _data;
        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
        }

        public void Init(Presenter presenter, BedsContainer bedsContainer, BedData data)
        {
            Presenter = presenter;
            _bedsContainer = bedsContainer;
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
            _bedsContainer.GetBedSlotById(id).GetComponentInChildren<MeshFilter>().mesh = _data.СarrotsBedMesh;
        }
    }
}