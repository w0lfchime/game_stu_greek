using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class CharacterCore : MonoBehaviour 
{
    [Header("Meta")]
    public string characterName = "Rhea";


    [Header("Physics")]
    public float gravityForce; //example


    [Header("State Control")]
    protected Dictionary<string, CharacterState> stateDict = new Dictionary<string, CharacterState>();
    public string currentState;




    // MonoBehaviour - - - - - - - - - - - - - - - - - - - 
    public void Awake()
    {
        
    }
    public void Start()
    {
        
    }

    public void Update()
    {
        stateDict[currentState]?.Update();
    }

    public void FixedUpdate()
    {
        stateDict[currentState]?.FixedUpdate();
    }

    public void LateUpdate()
    {
        stateDict[currentState]?.LateUpdate();
    }


    // Setup
    public void Setup()
    {

    }

    public void RegisterCharacterStates()
    {

    }

    // State

    public void SetState(string newState)
    {
        //check state
        if (!ApproveState(newState))
        {
            Debug.Log("Failed to set state.");
            return;
        }


        //good to go...

        //exit current state
        stateDict[currentState]?.Exit();

        //set new state
        currentState = newState;

        //enter new state
        stateDict[currentState]?.Enter();
        
    }

    public bool ApproveState(string state)
    {
        if (state == null)
        {
            Debug.Log("Null state not allowed.");
            return false;
        }
        if (stateDict[state] == null)
        {
            Debug.Log($"State {state} is null in stateDict.");
            return false;
        }
        if (!stateDict.ContainsKey(state))
        {
            Debug.Log($"State {state} does not exist in stateDict.");
            return false;
        }

        return true;
    }








}
