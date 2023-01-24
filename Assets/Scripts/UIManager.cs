using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject colourWheel, YouwonTitle,RestartButton,SelectLevelsButton,ballon1,balloon2, BalloonTitle;
    void Start()
    {
        LeanTween.rotateAround(colourWheel, Vector3.forward, -360f, 10f).setLoopClamp();
        LeanTween.scale(YouwonTitle, new Vector3(5.78f, 1.6f, 4f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
       LeanTween.moveLocal(YouwonTitle, new Vector3(0f, 315f, 0f), .7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(YouwonTitle, new Vector3(5f, 1.38f, 3.4f),.9f).setDelay(2.2f).setLoopPingPong();
        LeanTween.scale(RestartButton, new Vector3(2.4f, 2.64f, 2.4f), 2f).setDelay(1.7f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(SelectLevelsButton, new Vector3(2.4f, 2.64f, 2.4f), 2f).setDelay(1.99f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.rotateZ(ballon1, 45, 2f).setDelay(.6f).setLoopPingPong();
        LeanTween.rotateZ(balloon2, -45, 2f).setDelay(.6f).setLoopPingPong();


        LeanTween.scale(BalloonTitle, new Vector3(1f, 1f, 1f), 2f).setEase(LeanTweenType.easeOutElastic);
    }



}
