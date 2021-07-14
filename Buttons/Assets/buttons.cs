using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void Load(int sceneid)
    {
        SceneManager.LoadScene(sceneid);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
