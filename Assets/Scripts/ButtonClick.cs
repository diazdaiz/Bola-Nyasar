using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {
    public void OnStartButtonClicked() {
        SceneManager.LoadScene(1);
        Debug.Log("Start");
    }

    public void OnQuitButtonClicked() {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void OnRetryButtonClicked() {
        SceneManager.LoadScene(1);
        Debug.Log("Retry");
    }
    public void OnMainMenuButtonClicked() {
        SceneManager.LoadScene(0);
        Debug.Log("Main Menu");
    }

}
