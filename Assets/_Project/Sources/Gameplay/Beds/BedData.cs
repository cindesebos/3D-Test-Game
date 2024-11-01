using System.Collections.Generic;
using UnityEngine;

namespace Sources.Gameplay.Beds
{
    [CreateAssetMenu(menuName = "Source/Datas/Bed", fileName = "BedData", order = 0)]
    public class BedData : ScriptableObject
    {
        [SerializeField] private int _purchasePrice;
        [Space]

        [SerializeField] private Mesh _emptyBedMesh;
        [SerializeField] private Mesh _carrotsBedMesh;

        public int PurchasePrice => _purchasePrice;
        public Mesh EmptyBedMesh => _emptyBedMesh;
        public Mesh СarrotsBedMesh => _carrotsBedMesh;
    }
}