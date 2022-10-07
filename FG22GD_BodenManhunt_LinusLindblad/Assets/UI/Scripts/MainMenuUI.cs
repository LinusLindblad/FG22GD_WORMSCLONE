using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class MainMenuUI : MonoBehaviour
{   
    // Serialized to make it ez to change scale etc for hover anims
    [SerializeField] private GameObject controlsScreen;
    [SerializeField] private GameObject mainScreen;

    void Start()
    {
        Cursor.visible = true;
        controlsScreen.SetActive(false);

    }

    public void OnPlayClicked()
    {
        SceneManager.LoadScene("TestOutdoors");
    }

    public void OnControlsClicked()
    {
        mainScreen.SetActive(false);
        controlsScreen.SetActive(true);
    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }

    public void OnBackClicked()
    {
        mainScreen.SetActive(true);
        controlsScreen.SetActive(false);
    }
}
