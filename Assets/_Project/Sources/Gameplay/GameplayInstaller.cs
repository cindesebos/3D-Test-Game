using Sources.Gameplay.Beds;
using Sources.Gameplay.BedsCreator;
using UnityEngine;
using Zenject;

namespace Sources.Gameplay
{
    public class GameplayInstaller : MonoInstaller
    {
        [SerializeField] private BedData _bedData;
        [SerializeField] private BedsContainer _bedsContainer;
        
        public override void InstallBindings()
        {
            BindBedData();
            BindBedsContainer();
            BindCreator();
        }

        public void BindBedData()
        {
            Container.Bind<BedData>()
                .FromInstance(_bedData)
                .AsSingle();
        }

        public void BindBedsContainer()
        {
            Container.Bind<BedsContainer>()
                .FromInstance(_bedsContainer)
                .AsSingle();
        }

        public void BindCreator()
        {
            Container.Bind<ICreator>()
                .To<Creator>()
                .AsSingle();
        }
    }
}
