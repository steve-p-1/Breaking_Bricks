using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasNav : MonoBehaviour
{
    // Vars
    [SerializeField] 

    //Methods
     public void LoadNextScene()
    {
        GameManager.Instance.NextScene();
    }

    public void LoadStartScreen()
    {
        GameManager.Instance.StartScene();
    }
    // Accessors


}
