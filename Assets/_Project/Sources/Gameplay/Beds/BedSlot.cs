using UnityEngine;

namespace Sources.Gameplay.Beds
{
    public class BedSlot : MonoBehaviour
    {
        [SerializeField] private int _id;

        public int Id => _id;
    }
}