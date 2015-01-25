using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPCScript : MonoBehaviour 
{
    TextState defaultState;
    TextState currState;
    public List<TextState> allStates;

	
	// Update is called once per frame
	void Update () 
    {
	}
    public void setCurrentState(TextState state)
    {
        currState = state;
    }
    public TextState getCurrentState()
    {
        return currState;
    }
    public void setAllStates(List<TextState> list)
    {
        allStates = list;
        defaultState = currState = allStates[0];
        //Debug.Log(currState.getDisplay());
    }
}
