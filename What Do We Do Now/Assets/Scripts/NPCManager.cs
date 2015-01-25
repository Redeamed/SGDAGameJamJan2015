using UnityEngine;
using System.Collections;

public class NPCManager : MonoBehaviour
{
    static public NPCManager singleton;
    public GameObject NPC01;

    public GameObject activeNPC;
    NPCAI activeAI;
    int state = 0;
    int internalState = 0;

    // Use this for initialization
    void Start()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else
        {
            Debug.Log("Can not create duplicate NPCManager");
        }
        //initialize the states for the first NPC
        NPC01Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (activeNPC != null)
        {
            if (activeAI == null)
            {
                activeAI = activeNPC.GetComponent<NPCAI>();
            }
            Debug.Log(activeAI.getDisplay(state));
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state += 1;
            }
        }
    }
    void resetActiveNPC()
    {
        activeNPC = null;
        activeAI = null;
        state = 0;
    }
    void NPC01Init()
    {
        NPCAI ai = NPC01.GetComponent<NPCAI>();
        ai.addNPCState(); //add empty state 0
        ai.setNPCState(0, 0, "This is the forst state.", null, .5f);
        ai.setNPCState(0, 1, "This is the first target state.", null, .5f);
        ai.setNPCState(0, 2, "This is the Second target state.", null, .5f);
        ai.setNPCState(0, 3, "This is the third target state.", null, .5f);
        ai.setNPCState(0, 4, "This is the fourth target state.", null, .5f);

        ai.addNPCState(); //add empty state 1
        ai.setNPCState(1, 0, "his is the first target state.", null, .5f);
        ai.setNPCState(1, 1, "This is the first target state.", null, .5f);
        ai.setNPCState(1, 2, "This is the Second target state.", null, .5f);
        ai.setNPCState(1, 3, "This is the third target state.", null, .5f);
        ai.setNPCState(1, 4, "This is the fourth target state.", null, .5f);





    }
}
