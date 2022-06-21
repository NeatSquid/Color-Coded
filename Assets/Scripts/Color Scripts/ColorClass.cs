using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Color_Scripts
{
    public class ColorClass : MonoBehaviour
    {
        public Color[] color0;
        public Color[] color1;
        public Color[] color2;

        public static Color[] ColorArray;

        private void OnEnable()
        {
            OnChangeColor();
        }

        private void OnChangeColor()
        {
            var randomCol = Random.Range(0, 2);

            PlayerPrefs.SetInt("ColorSelect", randomCol);
            PlayerPrefs.GetInt("ColorSelect");

            if (PlayerPrefs.GetInt("ColorSelect") == 0)
                ColorArray = color0;
            else if (PlayerPrefs.GetInt("ColorSelect") == 1)
                ColorArray = color1;
            else if (PlayerPrefs.GetInt("ColorSelect") == 2)
                ColorArray = color2;
        }
    }
}