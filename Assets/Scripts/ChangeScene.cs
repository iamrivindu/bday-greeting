using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour {

	public void greetingCard()
    {
        SceneManager.LoadScene("greetingCardScene");
    }


    public void greetingMessage()
    {
        SceneManager.LoadScene("greetingMessageScene");
    }

    public void greetingCube()
    {
        SceneManager.LoadScene("greetingCubeScene");
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Exit button clicked");
    }
}
