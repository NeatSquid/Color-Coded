using Color_Scripts;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Handler_Scripts
{
    public class BallHandler : MonoBehaviour
    {
        public static float RotationSpeed = 99f;
        public static float RotationTime = 3f;
        public static int CurrentCircleIndex;

        private int _ballsCount;
        private int _circleIndex;

        public static Color BaseColor;
        public GameObject ball;

        public float speed = 100;

        public Color[] colorToChange;

        public SpriteRenderer spriteRenderer;
        public Material splashMaterial;

        private void Start()
        {
            ResetGame();
        }

        private void ResetGame()
        {
            colorToChange = ColorClass.ColorArray;
            BaseColor = colorToChange[0];

            spriteRenderer.color = BaseColor;
            splashMaterial.color = BaseColor;

            var go = Instantiate(Resources.Load("Round" + Random.Range(1, 4))) as GameObject;
            go.transform.position = new Vector3(0f, 20f, 23f);
            go.name = "Circle" + _circleIndex;

            _ballsCount = LevelsHandler.BallsCount;

            BaseColor = colorToChange[0];

            CurrentCircleIndex = _circleIndex;
            LevelsHandler.CurrentColor = BaseColor;

            SpawnPanels();
        }

        public void HitBall()
        {
            if (_ballsCount <= 1)
            {
                Invoke(nameof(MakeCircle), .4f);
                //temporary disable button
            }

            _ballsCount--;

            var go = Instantiate(ball, new Vector3(0f, 0f, -8f), Quaternion.identity);
            go.GetComponent<MeshRenderer>().material.color = BaseColor;
            go.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }

        private void MakeCircle()
        {
            var arr = GameObject.FindGameObjectsWithTag("circle");
            var goo = GameObject.Find("Circle" + _circleIndex);
            for (var i = 0; i < 24; i++)
            {
                goo.transform.GetChild(i).gameObject.SetActive(false);
            }

            goo.transform.GetChild(24).gameObject.GetComponent<MeshRenderer>().material.color = BaseColor;

            if (goo.GetComponent<iTween>())
            {
                goo.GetComponent<iTween>().enabled = false;
            }

            foreach (var item in arr)
            {
                iTween.MoveBy(item, iTween.Hash("y", -2.98f, "easetype", iTween.EaseType.spring, "time", .5));
            }

            _circleIndex++;
            CurrentCircleIndex = _circleIndex;

            var go = Instantiate(Resources.Load("Round" + Random.Range(1, 4))) as GameObject;
            go.transform.position = new Vector3(0f, 20f, 23f);
            go.name = "Circle" + _circleIndex;

            _ballsCount = LevelsHandler.BallsCount;

            BaseColor = colorToChange[_circleIndex];
            spriteRenderer.color = BaseColor;
            splashMaterial.color = BaseColor;

            LevelsHandler.CurrentColor = BaseColor;

            SpawnPanels();
        }

        private void SpawnPanels()
        {
            switch (_circleIndex)
            {
                case 0:
                    FindObjectOfType<LevelsHandler>().SpawnPanels0();
                    break;
                case 1:
                    FindObjectOfType<LevelsHandler>().SpawnPanels1();
                    break;
                case 2:
                    FindObjectOfType<LevelsHandler>().SpawnPanels2();
                    break;
                case 3:
                    FindObjectOfType<LevelsHandler>().SpawnPanels3();
                    break;
                case 4:
                    FindObjectOfType<LevelsHandler>().SpawnPanels4();
                    break;
            }
        }
    }
}