using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurnController : MonoBehaviour
{
    //The turnController handles all turn dependent behavior, and ensures that only the relevant object is active.
    private List<TurnBasedObject> _turnBasedObjects = new List<TurnBasedObject>();
    private TurnBasedInput _turnBasedInput;
    private int _activeObjectID = 0;
    private MultiTargetCamera _camControl;

    //Counts the number of transpired turns incase one wants to use delayed behavior
    [HideInInspector] public int TurnNumber;
    [HideInInspector] public float TurnTimer;
    private UI_Controller _uIController;
    
    public float TurnTimerMax;

    void Start()
    {
        var turnBasedObjectHolder = FindObjectsOfType<TurnBasedObject>();

        for (int i = 0; i < turnBasedObjectHolder.Length; i++)
        {
            _turnBasedObjects.Add(turnBasedObjectHolder[i]);
        }

        _turnBasedInput = FindObjectOfType<TurnBasedInput>();
        _camControl = FindObjectOfType<MultiTargetCamera>();
        _uIController = FindObjectOfType<UI_Controller>();

        TurnTimer = TurnTimerMax;
        NextTurn();
    }
 
    void Update()
    {
        if(_turnBasedObjects.Count <= 1)
        {
            EndGame();
        }

        //Checks if the currently active turnbasedobject is affected by the turn timer
        if (_turnBasedObjects[_activeObjectID == 0 ? _turnBasedObjects.Count - 1 : _activeObjectID - 1].AffectedByTimer() == true && _camControl.TransitionComplete == true)
        {
            CountDown();
        }   
    }

    private void CountDown()
    {
        if(TurnTimer <= 0f)
        {
            TurnTimer = TurnTimerMax;
            _turnBasedObjects[_activeObjectID == 0 ? _turnBasedObjects.Count - 1 : _activeObjectID - 1].EndTurn();
        }
        else
        {
            TurnTimer -= 1f * Time.deltaTime;
        }
    }
      
    public void NextTurn()
    {
        //Checks if the ID is larger than the list due to the edgecase where the player next up died during the last turn
        if (_activeObjectID >= _turnBasedObjects.Count || _activeObjectID < 0)
        {
            _activeObjectID = 0;
        }

        _camControl.SwapCamera(_turnBasedObjects[_activeObjectID].ObjectCamera());

        _turnBasedObjects[_activeObjectID].StartTurn();

        if (_turnBasedObjects[_activeObjectID].GetComponent<Player_OmniController>() != null)
        {
            _turnBasedInput.InputEnabled = true;
            _turnBasedInput.ChangeTarget(_turnBasedObjects[_activeObjectID].GetComponent<Player_OmniController>());
            _uIController.ChangePlayer(_turnBasedObjects[_activeObjectID].GetComponent<Player_OmniController>());
        }
        else
        {
            _turnBasedInput.InputEnabled = false;
        }

        _activeObjectID++;

        //Loops ID to go back to player 0
        if (_activeObjectID >= _turnBasedObjects.Count)
        {
            _activeObjectID = 0;
        }

        TurnTimer = TurnTimerMax;

        TurnNumber++;
    }

    public void RemoveFromTurnOrder(TurnBasedObject target)
    {
        if (_turnBasedObjects[_activeObjectID == 0 ? _turnBasedObjects.Count - 1 : _activeObjectID - 1] == target)
        {
            Debug.Log("Going to next turn");
            //_activeObjectID--;
            _turnBasedObjects.Remove(target);
            NextTurn();
        }
        else
        {
            _turnBasedObjects.Remove(target);
        }

        target.gameObject.SetActive(false);
    }

    public void EndGame()
    {
        SceneManager.LoadScene("EndGame");
    }
}
