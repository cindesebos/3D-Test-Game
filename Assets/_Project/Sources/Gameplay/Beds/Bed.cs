using Sources.Gameplay.Economy;
using UnityEngine;
using Zenject;

namespace Sources.Gameplay.Beds
{
    public abstract class Bed
    {
        public readonly BedData BedData;
        public readonly Bank Bank;

        public readonly int IncomeUnits;
        public readonly float CooldownIncome;

        private float _currentCooldownIncome;

        [Inject]
        public Bed(BedData bedData, Bank bank)
        {
            BedData = bedData;

            Bank = bank;

            IncomeUnits = BedData.IncomeUnits;
            CooldownIncome = BedData.CooldownIncome;
            _currentCooldownIncome = CooldownIncome;
        }

        public bool IsWorking { get; private set; }

        public void OnUpdate()
        {
            if(!IsWorking) return;

            if(_currentCooldownIncome <= 0)
            {
                MakeIncome();
                _currentCooldownIncome = CooldownIncome;
            }
            else _currentCooldownIncome -= Time.deltaTime;
        }

        protected virtual void MakeIncome() {}

        public void StartWork()
        {
            IsWorking = true;
        }

        public void StopWork() => IsWorking = false;
    }
}