using UnityEngine;
using System.Collections;

public class ClickNPC: MonoBehaviour {
    GameObject player;
    PlayerAI playerAI;
    CameraManagement cameraManage;
    Camera currCamera;
    LayerMask NPCMask;
	// Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerAI = player.GetComponent<PlayerAI>();
        cameraManage = GameObject.FindGameObjectWithTag("CameraManagement").GetComponent<CameraManagement>();
        NPCMask = LayerMask.GetMask("NPC");
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            currCamera = cameraManage.getCurrCamera();
            RaycastHit hit;
            Ray camRay = currCamera.ScreenPointToRay (Input.mousePosition);
           
            if (Physics.Raycast(camRay, out hit, Mathf.Infinity,NPCMask))
            {
                
                    NPCScript npcScript = hit.transform.GetComponent<NPCScript>();
                    NPCManager.singletonNPC.setActiveNPC(npcScript);
                   // Debug.Log(npcScript.getCurrentState().getDisplay());
                
            }
            //Debug.DrawRay(camRay.origin, camRay.direction * 100.0f, Color.green);
        }
	}

}
