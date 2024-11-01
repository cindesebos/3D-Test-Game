using Sources.Gameplay.Economy;
using UnityEngine;
using Zenject;

namespace Sources.Gameplay
{
    public class GameplayInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindBank();
        }

        private void BindBank()
        {
            Container.BindInterfacesAndSelfTo<Bank>()
                .AsSingle();
        }
    }
}
