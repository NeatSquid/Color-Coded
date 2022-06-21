using Handler_Scripts;
using UnityEngine;

namespace Circle_Scripts
{
    public class Circle3 : MonoBehaviour
    {
        private void Start()
        {
            iTween.MoveTo(gameObject,
                iTween.Hash("y", 0f, "easetype", iTween.EaseType.easeInOutQuad, "time", .6f, "OnComplete", "RotateCircle"));
        }

        private void Update() => transform.Rotate(Vector3.down * (Time.deltaTime * (BallHandler.RotationSpeed + 20f)));
    }
}