using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    public TextMeshProUGUI PlayerName;
    public TextMeshProUGUI Controls;
    public Scrollbar HpOverlay;
    public Scrollbar HpBase;
    public Scrollbar LanternProgress;
    public Material FrostMaterial;

    private Player_OmniController _currentPlayer;

    // Start is called before the first frame update
    void Awake()
    {
        FrostMaterial.SetFloat("_Warmth", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if(_currentPlayer != null)
        {
            if(_currentPlayer.PFreeze.FreezeLevel < 1)
            {
                FrostMaterial.SetFloat("_Warmth", Mathf.Lerp(FrostMaterial.GetFloat("_Warmth"), 2f, 0.85f * Time.deltaTime));
            }
            else if(_currentPlayer.PFreeze.FreezeLevel == 1)
            {
                FrostMaterial.SetFloat("_Warmth", Mathf.Lerp(FrostMaterial.GetFloat("_Warmth"), 0.5f, 1f * Time.deltaTime));
            }
            else if(_currentPlayer.PFreeze.FreezeLevel == 2)
            {
                FrostMaterial.SetFloat("_Warmth", Mathf.Lerp(FrostMaterial.GetFloat("_Warmth"), 0.35f, 1f * Time.deltaTime));
            }
            else if (_currentPlayer.PFreeze.FreezeLevel == 3)
            {
                FrostMaterial.SetFloat("_Warmth", Mathf.Lerp(FrostMaterial.GetFloat("_Warmth"), 0.2f, 1f * Time.deltaTime));
            }
            else if (_currentPlayer.PFreeze.FreezeLevel >= 4)
            {
                FrostMaterial.SetFloat("_Warmth", Mathf.Lerp(FrostMaterial.GetFloat("_Warmth"), 0.1f, 1f * Time.deltaTime));
            }
        }
    }

    public void ChangePlayer(Player_OmniController player)
    {
        FrostMaterial.SetFloat("_Warmth", 2f);
        PlayerName.text = player.name;
        HpOverlay.GetComponent<Image>().fillAmount = (player.PHealth.health * 0.01f) + 0.01f;
        _currentPlayer = player;
    }
}
