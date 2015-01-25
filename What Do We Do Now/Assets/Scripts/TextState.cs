using UnityEngine;
using System.Collections;

public class TextState : MonoBehaviour {

    Texture2D portrait;
    string display;
    float waitTime = 0.5f;

    public void setDisplay(string text)
    {
        display = text;
    }
    public string getDisplay()
    {
        return display;
    }

    public void setPortrait(Texture2D port)
    {
        portrait = port;
    }
    public Texture2D getPortrait()
    {
        return portrait;
    }

    public void setWait(float fWait)
    {
        waitTime = fWait;
    }
    public float getWait()
    {
        return waitTime;
    }
}
