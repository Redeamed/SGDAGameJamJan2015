using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class NPCManager : MonoBehaviour {
    public GameObject[] allNPC;
    public static NPCManager singletonNPC;
    public List<TextState> NPC1;

    NPCScript activeNPC;
    void Start()
    {
        if (singletonNPC == null)
        {
            singletonNPC = this;
        }
        else 
        {
            Debug.Log("Can not create dupicate NPCManager");
        }
        for (int i = 0; i < 5; ++i)
        {
            NPC1.Add(new TextState());
            NPC1[i].initial();
        }

        NPC1[0].setDisplayText("Hello World! What do we do now?");

        NPC1[1].setDisplayText("ZzzzZzzzzZzzzzZzzzz");
        NPC1[2].setDisplayText("**Sobs uncontrolably**");
        NPC1[3].setDisplayText("Work work work.");
        NPC1[4].setDisplayText("arrrrrggggggggg");
        NPC1[0].addTargetState(NPC1[1], "Sleep");
        NPC1[0].addTargetState(NPC1[2], "Cry");
        NPC1[0].addTargetState(NPC1[3], "Work");
        NPC1[0].addTargetState(NPC1[4], "Die");


        allNPC[0].GetComponent<NPCScript>().setAllStates(NPC1);
        
    }

    void Update()
    {
        if (activeNPC != null)
        {
            //Debug.Log(activeNPC.getCurrentState().getDisplay());
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (activeNPC.getCurrentState().getTargetState(0) != null)
                {

                    Debug.Log(activeNPC.getCurrentState().getDisplay());
                    activeNPC.setCurrentState(activeNPC.getCurrentState().getTargetState(0));
                    Debug.Log(activeNPC.getCurrentState().getDisplay());
                }
                else 
                {
                    Debug.Log("No path exists");
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (activeNPC.getCurrentState().getTargetState(1) != null)
                {
                    activeNPC.setCurrentState(activeNPC.getCurrentState().getTargetState(1));
                }
                else
                {
                    Debug.Log("No path exists");
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                if (activeNPC.getCurrentState().getTargetState(2) != null)
                {
                    activeNPC.setCurrentState(activeNPC.getCurrentState().getTargetState(2));
                }
                else
                {
                    Debug.Log("No path exists");
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                if (activeNPC.getCurrentState().getTargetState(3) != null)
                {
                    activeNPC.setCurrentState(activeNPC.getCurrentState().getTargetState(3));
                }
                else
                {
                    Debug.Log("No path exists");
                }
            }
        }
    }
    public void setActiveNPC(NPCScript aNPC)
    {
        activeNPC = aNPC;
    }
    public NPCScript getActiveNPC()
    {
        return activeNPC;
    }
}


public class TextState : MonoBehaviour 
{
    string displayText;
    TextState[] targetState;
    string[] targetText;

    public void initial()
    {
        displayText = "Text Needed";
        targetText = new string[4];
        targetState = new TextState[4];
        for (int i = 0; i < 4; i++)
        {
            targetText[i] = null;
            targetState[i] = null;
        }
    }
    public void setDisplayText(string dT)
    {
        displayText = dT;
    }
    public void addTargetState(TextState state, string stateText)
    {
        for (int i = 0; i < 4; ++i)
        {
            if (targetState[i] == null)
            {
                targetState[i] = state;
                targetText[i] = stateText;
                //Debug.Log(targetState[i].getDisplay());
                break;
            }
            else if (i == 3)
            {
                Debug.Log("Can not add more targetStates to TextState");
            }
            
        }
    }
    public TextState getTargetState(int i)
    {
        return targetState[i];
    }
    public string getDisplay()
    {
        return displayText;
    }
}
