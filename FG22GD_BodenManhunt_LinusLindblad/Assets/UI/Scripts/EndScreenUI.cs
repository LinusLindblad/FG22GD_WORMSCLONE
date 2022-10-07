using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenUI : MonoBehaviour
{
    [SerializeField] private TMP_Text playerTxt;
    private TMP_Text restartTxt;
    private TMP_Text quitTxt;
    
    // Variable used to store the winning player (just the gameobject name is fine) from the play scene (TODO)
    public GameObject winningPlayer;
    void Start()
    {
        Cursor.visible = true;
        playerTxt.text = winningPlayer.ToString() + " WON THE MANHUNT!";
    }

    public void OnRestartClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }
}
