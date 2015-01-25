using UnityEngine;
using System.Collections;

public class NPCState : MonoBehaviour {


    TextState[] allStates;
    public NPCState()
    {
        allStates = new TextState[5];
        for (int i = 0; i < 5; ++i)
        {
            allStates[i] = new TextState();
        }

    }

    public void initState(string display, Texture2D port, float waitTime, int array)
    {
        allStates[array].setDisplay(display);
        allStates[array].setPortrait(port);
        allStates[array].setWait(waitTime);
    }
    public TextState getThisState(int array)
    {
        return allStates[array];
    }



}
