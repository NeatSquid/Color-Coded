using UnityEngine;

namespace Circle_Scripts
{
    public class Circle1 : MonoBehaviour
    {
        private void Start()
        {
            iTween.MoveTo(gameObject,
                iTween.Hash("y", 0f, "easetype", iTween.EaseType.easeInCirc, "time", .2f, "OnComplete",
                    "RotateCircle"));
        }

        private void RotateCircle()
        {
            iTween.RotateBy(gameObject,
                iTween.Hash("y", .2f, "time", BallHandler.RotationTime, "easetype", iTween.EaseType.easeInOutQuad,
                    "looptype", iTween.LoopType.pingPong, "delay", 1.5f));
        }

        private void Update() => transform.Rotate(Vector3.up * (Time.deltaTime * BallHandler.RotationSpeed));
    }
}