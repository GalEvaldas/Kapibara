using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Screen.sleepTimeout = (int)0f;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    public void changeScene()
    {
        SceneManager.LoadScene("GamePage001");
    }
    public void changeScene2()
    {
        SceneManager.LoadScene("GamePage002");
    }
    public void changeScene3()
    {
        SceneManager.LoadScene("GamePage003");
    }
    public void changeScene4()
    {
        SceneManager.LoadScene("GamePage004");
    }
    public void changeScene5()
    {
        SceneManager.LoadScene("GamePage005");
    }
    public void changeScene6()
    {
        SceneManager.LoadScene("GamePage006");
    }
    public void changeScene7()
    {
        SceneManager.LoadScene("GamePage007");
    }
    public void changeScene8()
    {
        SceneManager.LoadScene("GamePage008");
    }
    public void changeScene9()
    {
        SceneManager.LoadScene("GamePage009");
    }
    public void changeScene10()
    {
        SceneManager.LoadScene("GamePage07");
    }
    public void changeScene11()
    {
        SceneManager.LoadScene("GamePage08");
    }
    public void changeScene12()
    {
        SceneManager.LoadScene("GamePage09");
    }
    public void changeScene13()
    {
        SceneManager.LoadScene("HomePage");
    }
    public void changeScene14()
    {
        SceneManager.LoadScene("LevelsPage");
    }
    public void changeScene15()
    {
        SceneManager.LoadScene("SettinsPage");
    }
}
