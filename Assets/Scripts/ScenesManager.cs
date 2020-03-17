using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour {

    public void MenuScene() {
        SceneManager.LoadScene("Menu");
        Debug.Log("Menu");
    }

    public void StartScene() {
        SceneManager.LoadScene("Start");
        Debug.Log("Mulai Permainan");
    }
    public void AlertQuitScene() {
        SceneManager.LoadScene("Alert Quit");
        Debug.Log("Alert");
    }

    public void keluar() {
        Application.Quit();
         Debug.Log("Quit");
    }
    
}