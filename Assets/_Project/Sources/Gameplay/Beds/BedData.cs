using System.Collections.Generic;
using UnityEngine;

namespace Sources.Gameplay.Beds
{
    [CreateAssetMenu(menuName = "Source/Datas/Bed", fileName = "BedData", order = 0)]
    public class BedData : ScriptableObject
    {
        [SerializeField] private int _purchasePrice;
        [SerializeField] private int _incomeUnits;
        [SerializeField] private float _cooldownIncome;
        [Space]

        [SerializeField] private Mesh _emptyBedMesh;
        [SerializeField] private Mesh _carrotsBedMesh;

        public int PurchasePrice => _purchasePrice;
        public int IncomeUnits => _incomeUnits;
        public float CooldownIncome => _cooldownIncome;
        public Mesh EmptyBedMesh => _emptyBedMesh;
        public Mesh СarrotsBedMesh => _carrotsBedMesh;
    }
}