using Sources.Gameplay.Beds;
using Zenject;

namespace Sources.Gameplay.BedsCreator
{
    public class Creator : ICreator
    {
        private readonly DiContainer _diContainer;
        private readonly BedsContainer _bedsContainer;

        [Inject]
        public Creator(DiContainer diContainer, BedsContainer bedsContainer)
        {
            _diContainer = diContainer;
            _bedsContainer = bedsContainer;
        }

        public CarrotBed CreateCarrotBed()
        {
            CarrotBed carrotBed = _diContainer.Instantiate<CarrotBed>();

            _bedsContainer.AddBed(carrotBed);

            return carrotBed;
        }
    }
}