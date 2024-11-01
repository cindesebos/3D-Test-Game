using UnityEngine;
using R3;
using TMPro;

namespace Sources.Gameplay.Economy
{
    public class BankView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _goldText;

        private CompositeDisposable _disposable = new CompositeDisposable();

        public void Init(Bank bank)
        {
            bank.Gold.Value.Subscribe(value =>
            {
                _goldText.text = "Gold: " + value;   
            }).AddTo(_disposable);
        }
    }
}