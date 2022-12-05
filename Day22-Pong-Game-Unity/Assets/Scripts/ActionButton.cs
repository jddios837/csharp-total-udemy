using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionButton : MonoBehaviour
{
    public void Button_Click()
    {
        SceneManager.LoadScene("Scenes/Level1");
    }

    public void Button_Back_Clicked()
    {
        SceneManager.LoadScene("Scenes/Initial");
    }

    public void ChangeScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
}
