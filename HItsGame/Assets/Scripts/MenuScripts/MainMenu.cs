using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play(int index)
    {
        SceneManager.LoadScene(index);
    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
}
