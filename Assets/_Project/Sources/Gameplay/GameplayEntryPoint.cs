using Sources.Gameplay.Beds;
using UnityEngine;
using System.Collections.Generic;
using Zenject;
using Sources.Gameplay.Economy;
using Sources.Gameplay.BedsCreator;

namespace Sources.Gameplay
{
    public class GameplayEntryPoint : MonoBehaviour
    {
        [SerializeField] private BankView _bankView;
        [Space]

        [SerializeField] private BedView _bedView;

        private BedData _bedData;
        private Bank _bank;
        private ICreator _creator;
        private BedsContainer _bedsContainer;

        [Inject]
        private void Construct(Bank bank, BedData bedData, ICreator creator, BedsContainer bedsContainer)
        {
            _bank = bank;
            _bedData = bedData;
            _creator = creator;
            _bedsContainer = bedsContainer;
        }
        
        private void Awake()
        {
            _bedsContainer.InitBedSlots(_bedData);

            _bankView.Init(_bank);

            BedModel bedModel = new BedModel(_bedView, _bedsContainer, _bank);
            BedPresenter bedPresenter = new BedPresenter(bedModel, _creator);
            _bedView.Init(bedPresenter, _bedsContainer, _bedData);
        }
    }
}