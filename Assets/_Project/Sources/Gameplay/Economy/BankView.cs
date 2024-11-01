using UnityEngine;
using R3;
using TMPro;

namespace Sources.Gameplay.Economy
{
    public class BankView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _goldText;
        [SerializeField] private TextMeshProUGUI _carrotText;

        private CompositeDisposable _disposable = new CompositeDisposable();

        public void Init(Bank bank)
        {
            bank.Gold.Value.Subscribe(value =>
            {
                _goldText.text = value.ToString();   
            }).AddTo(_disposable);

            bank.Carrot.Value.Subscribe(value =>
            {
                _carrotText.text = value.ToString();   
            }).AddTo(_disposable);
        }
    }
}