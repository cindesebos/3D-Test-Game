using UnityEngine;

namespace Sources.MVP
{
    public abstract class View : MonoBehaviour
    {
        protected Presenter Presenter;

        public virtual void Init(Presenter presenter)
        {
            Presenter = presenter;
        }

        public virtual void SetCarrotsBedMesh(int id) {}
    }
}