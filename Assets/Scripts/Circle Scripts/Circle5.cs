using Handler_Scripts;
using UnityEngine;

namespace Circle_Scripts
{
    public class Circle5 : MonoBehaviour
    {
        private void Start()
        {
            iTween.MoveTo(gameObject,
                iTween.Hash("y", 0f, "easetype", iTween.EaseType.easeInOutQuad, "time", .6f, "OnComplete", "RotateCircle"));
        }

        private void RotateCircle()
        {
            iTween.RotateBy(gameObject,
                iTween.Hash("y", .1f, "time", BallHandler.RotationTime, "easetype", iTween.EaseType.easeInOutQuad,
                    "loopType", iTween.LoopType.pingPong, "delay", 1f));
        }
    }
}