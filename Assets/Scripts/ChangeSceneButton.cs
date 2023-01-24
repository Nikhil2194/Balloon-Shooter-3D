using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneButton : MonoBehaviour
{
public void ChangeScene(string _sceneName)
    {
        LevelManager.Instance.LoadScene(_sceneName);
    }
}
