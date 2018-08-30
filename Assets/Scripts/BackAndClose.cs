using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackAndClose : MonoBehaviour {

	public void backButton()
    {
        SceneManager.LoadScene("startMenuScene");
    }
    public void closeButton()
    {
        Application.Quit();
        Debug.Log("Close button clicked");
    }
}
