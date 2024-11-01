using Sources.Gameplay.Beds;
using UnityEngine;
using System.Collections.Generic;
using Zenject;
using Sources.Gameplay.Economy;

namespace Sources.Gameplay
{
    public class GameplayEntryPoint : MonoBehaviour
    {
        [SerializeField] private BankView _bankView;
        [Space]

        [SerializeField] private BedContainer _bedContainer;
        [SerializeField] private BedView _bedView;
        [SerializeField] private BedData _bedData;

        private Bank _bank;

        [Inject]
        private void Construct(Bank bank)
        {
            _bank = bank;
        }
        
        private void Awake()
        {
            _bedContainer.InitBedSlots(_bedData);

            _bankView.Init(_bank);

            BedModel bedModel = new BedModel(_bedView, _bedContainer, _bank);
            BedPresenter bedPresenter = new BedPresenter(bedModel);
            _bedView.Init(bedPresenter, _bedContainer, _bedData);
        }
    }
}