using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class NPCAI : MonoBehaviour
{

    List<NPCState> npcState;
    int[][] stateVal;
    void Start()
    {
        npcState = new List<NPCState>();
    }
    public void addNPCState()
    {
        npcState.Add( new NPCState() ); // still will need the values of the state modified.
    }
    public void setNPCState(int array, int array2, string display, Texture2D port, float waitTime)
    {
        npcState[array].initState(display, port, waitTime, array2);
    }
    public string getDisplay(int i)
    {
        return npcState[i].getThisState(0).getDisplay();
    }

}