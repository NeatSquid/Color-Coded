using UnityEngine;

namespace Circle_Scripts
{
    public class Circle1 : MonoBehaviour
    {
        private void Start()
        {
            iTween.MoveTo(gameObject, iTween.Hash(new object[]
            {
                "y",
                0f,
                "easetype",
                iTween.EaseType.easeInCirc,
                "time",
                .2f,
                "OnComplete",
                "RotateCircle",
            }));
        }

        private void RotateCircle()
        {
            print("Itween final called");
        }

        private void Update()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * BallHandler.RotationSpeed));
        }
    }
}