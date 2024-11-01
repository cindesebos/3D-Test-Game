using Sources.Gameplay.Economy;
using UnityEngine;
using Zenject;

namespace Sources.Gameplay.Beds
{
    public class CarrotBed : Bed
    {
        [Inject]
        public CarrotBed(BedData bedData, Bank bank) : base(bedData, bank) { Debug.Log("Injected carrot"); }

        protected override void MakeIncome()
        {
            if(Bank.Carrot.TryAdd(IncomeUnits))
            {
                Debug.Log("incomed");
            }
        }
    }
}