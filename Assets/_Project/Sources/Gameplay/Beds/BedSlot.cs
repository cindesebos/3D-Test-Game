using UnityEngine;

namespace Sources.Gameplay.Beds
{
    public class BedSlot : MonoBehaviour
    {
        public int Id { get; private set; }
        public int PurchasePrice { get; private set; }

        public void Init(int id, BedData data)
        {
            Id = id;
            PurchasePrice = data.PurchasePrice;
        }
    }
}