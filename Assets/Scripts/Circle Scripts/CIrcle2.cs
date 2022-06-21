using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CIrcle2 : MonoBehaviour
{
    private void Start()
    {
        iTween.MoveTo(gameObject,
            iTween.Hash("y", 0f, "easetype", iTween.EaseType.easeInOutQuad, "time", .6f, "OnComplete", "RotateCircle"));
    }

    private void RotateCircle()
    {
        iTween.RotateBy(gameObject,
            iTween.Hash("y", .8f, "time", BallHandler.RotationTime, "easetype", iTween.EaseType.easeInOutQuad,
                "looptype", iTween.LoopType.pingPong, "delay", .4f));
    }
}