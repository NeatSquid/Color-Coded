using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Handler_Scripts
{
    public class LevelsHandler : MonoBehaviour
    {
        public static int CurrentLevel;
        public static int BallsCount;
        public static int TotalCircles;

        public static Color CurrentColor;

        private void Awake()
        {
            if (PlayerPrefs.GetInt("firstTime1", 0) == 0)
            {
                PlayerPrefs.SetInt("firstTime1", 1);
                PlayerPrefs.SetInt("C_Level", 1);
                //add more stuff
            }

            LevelUpdate();
        }

        private void LevelUpdate()
        {
            CurrentLevel = PlayerPrefs.GetInt("C_Level", 1);

            switch (CurrentLevel)
            {
                case 1:
                    BallsCount = 3;
                    TotalCircles = 2;
                    break;
                case 2:
                    BallsCount = 3;
                    TotalCircles = 3;
                    break;
                case 3:
                    BallsCount = 3;
                    TotalCircles = 4;
                    break;
                case 4:
                    BallsCount = 3;
                    TotalCircles = 5;
                    break;
                case 5:
                    BallsCount = 3;
                    TotalCircles = 5;
                    break;
                case 6:
                    BallsCount = 3;
                    TotalCircles = 5;
                    break;
                case >= 8 and <= 20:
                    BallsCount = 4;
                    TotalCircles = 5;
                    break;
                case >= 12 and <= 21:
                    BallsCount = 4;
                    TotalCircles = 6;
                    BallHandler.RotationSpeed = 120f;
                    BallHandler.RotationSpeed = 2f;
                    break;
                case >= 21:
                    BallsCount = 5;
                    TotalCircles = 6;
                    BallHandler.RotationSpeed = 140f;
                    BallHandler.RotationSpeed = 1f;
                    break;
            }
        }

        public void SpawnPanels0()
        {
            var go = GameObject.Find("Circle" + BallHandler.CurrentCircleIndex);

            var i = Random.Range(1, 3);

            go.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().enabled = true;
            go.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material.color = CurrentColor;
            go.transform.GetChild(i).gameObject.tag = "Red";
        }

        public void SpawnPanels1()
        {
            var go = GameObject.Find("Circle" + BallHandler.CurrentCircleIndex);

            var iArr = new int[]
            {
                Random.Range(1, 3),
                Random.Range(15, 17)
            };

            for (var i = 0; i < iArr.Length; i++)
            {
                go.transform.GetChild(iArr[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
                go.transform.GetChild(iArr[i]).gameObject.GetComponent<MeshRenderer>().material.color = CurrentColor;
                go.transform.GetChild(iArr[i]).gameObject.tag = "Red";
            }
        }

        public void SpawnPanels2()
        {
            var go = GameObject.Find("Circle" + BallHandler.CurrentCircleIndex);

            var iArr = new int[]
            {
                Random.Range(1, 3),
                Random.Range(4, 6),
                Random.Range(18, 20)
            };

            for (var i = 0; i < iArr.Length; i++)
            {
                go.transform.GetChild(iArr[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
                go.transform.GetChild(iArr[i]).gameObject.GetComponent<MeshRenderer>().material.color = CurrentColor;
                go.transform.GetChild(iArr[i]).gameObject.tag = "Red";
            }
        }

        public void SpawnPanels3()
        {
            var go = GameObject.Find("Circle" + BallHandler.CurrentCircleIndex);

            var iArr = new int[]
            {
                Random.Range(1, 3),
                Random.Range(4, 6),
                Random.Range(13, 15),
                Random.Range(22, 24)
            };

            for (var i = 0; i < iArr.Length; i++)
            {
                go.transform.GetChild(iArr[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
                go.transform.GetChild(iArr[i]).gameObject.GetComponent<MeshRenderer>().material.color = CurrentColor;
                go.transform.GetChild(iArr[i]).gameObject.tag = "Red";
            }
        }

        public void SpawnPanels4()
        {
            var go = GameObject.Find("Circle" + BallHandler.CurrentCircleIndex);

            var iArr = new int[]
            {
                Random.Range(1, 3),
                Random.Range(11, 13),
                Random.Range(13, 15),
                Random.Range(22, 24),
                Random.Range(15, 17)
            };

            for (var i = 0; i < iArr.Length; i++)
            {
                go.transform.GetChild(iArr[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
                go.transform.GetChild(iArr[i]).gameObject.GetComponent<MeshRenderer>().material.color = CurrentColor;
                go.transform.GetChild(iArr[i]).gameObject.tag = "Red";
            }
        }
    }
}