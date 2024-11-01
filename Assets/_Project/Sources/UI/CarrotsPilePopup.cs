using UnityEngine;

namespace Sources.UI
{
    public class CarrotsPilePopup : MonoBehaviour
    {
        [SerializeField] private GameObject _pileOfCarrotsParent;

        private Vector3[] _initialPositions;
        private Quaternion[] _initialRotations;

        private void Start()
        {
            for (int i = 0; i < _pileOfCarrotsParent.transform.childCount; i++)
            {
                _initialPositions[i] = GetCarrotTransformById(i).position;
                _initialRotations[i] = GetCarrotTransformById(i).rotation;
            }
        }

        private void Reset()
        {
            for (int i = 0; i < _pileOfCarrotsParent.transform.childCount; i++)
            {
                GetCarrotTransformById(i).position = _initialPositions[i];
                GetCarrotTransformById(i).rotation = _initialRotations[i];
            }
        }

        public void Show()
        {
            Reset();

            float delay = 0f;

            _pileOfCarrotsParent.SetActive(true);

            for (int i = 0; i < _pileOfCarrotsParent.transform.childCount; i++)
            {

            }
        }

        private Transform GetCarrotTransformById(int id) => _pileOfCarrotsParent.transform.GetChild(id);
    }
}
