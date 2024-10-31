using UnityEngine;
namespace Chapter.State
{
    public class BikeStartState : MonoBehaviour, IBikeState
    {
        private BikeController _bikeController;
        public void Handle(BikeController bikeController)
        {
            if (!_bikeController)   //if not bikecontroller, then bike controller becomes bikecontroller
                _bikeController = bikeController;
            _bikeController.CurrentSpeed =               //bikecontroller goes to max speed
            _bikeController.maxSpeed;
        }
        void Update()
        {
            if (_bikeController)
            {
                if (_bikeController.CurrentSpeed > 0)
                {
                    _bikeController.transform.Translate(
                    Vector3.forward * (
                    _bikeController.CurrentSpeed *
                    Time.deltaTime));
                }
            }
        }
    }
}