using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerStart : MonoBehaviour
{
    [SerializeField] GameObject Wheel, StartButton, GameTitle, Ballon1,balloon2;
    void Start()
    {
        LeanTween.rotateAround(Wheel, Vector3.forward, -360f, 10f).setLoopClamp();
        LeanTween.scale(GameTitle, new Vector3(1f, 1f, 1f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveLocal(GameTitle, new Vector3(0f, 31f, 0f), .7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(GameTitle, new Vector3(1.2f, 1.2f, 1.2f), .9f).setDelay(2.2f).setLoopPingPong();
        LeanTween.scale(StartButton, new Vector3(2.4f, 2.64f, 2.4f), 2f).setDelay(1.7f).setEase(LeanTweenType.easeInOutCubic);


        LeanTween.scale(Ballon1, new Vector3(2.52f, 3.15f, 2.52f), 2f).setDelay(.7f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(balloon2, new Vector3(2.52f, 3.15f, 2.52f), 2f).setDelay(.9f).setEase(LeanTweenType.easeInOutCubic);

    }

   
}
