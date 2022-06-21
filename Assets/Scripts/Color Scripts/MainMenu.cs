using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class MainMenu : MonoBehaviour
{
    public Image bg;
    public Sprite[] sprites;

    private void Start()
    {
        bg.sprite = sprites[Random.Range(0, 4)];
    }
}