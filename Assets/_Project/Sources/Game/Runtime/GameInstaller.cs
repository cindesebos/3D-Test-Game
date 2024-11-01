using Sources.Gameplay.Economy;
using Zenject;

namespace Sources.Gameplay
{
    public class GameInstaller : MonoInstaller
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
