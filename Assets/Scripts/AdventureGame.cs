using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text storyText;
    [SerializeField] Text actionText;
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] Image image;
    [SerializeField] State startingState;
    State[] nextStates;

    State state;

    // Use this for initialization
    void Start ()
    {
        state = startingState;
        PresentState();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ManageState();
	}

    private void ManageState()
    {

        if(state != startingState)
        {
            titleText.gameObject.SetActive(false);
        }
        else
        {
            titleText.gameObject.SetActive(true);
        }

        var nextStates = state.GetNextStates();

        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            if (nextStates[0] != null)
            {
                state = nextStates[0];
            }
            else
            {
                Debug.Log("No first action to perform.");
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            if(nextStates[1] != null)
            {
                state = nextStates[1];
            }
            else
            {
                Debug.Log("No second action to perform.");
            }
        }

        PresentState();
    }

    private void PresentState()
    {
        storyText.text = state.GetStateStory();
        actionText.text = state.GetStateActions();
        image.sprite = state.GetStateSprite();
    }
}
