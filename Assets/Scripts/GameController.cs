using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public static GameController instance;

    public UI uiScript;

    static int killCounter = 0;
    static int lifeCounter = 5;

    void Awake()
    {
        killCounter = 0;
        lifeCounter = 5;

        if (uiScript == null)
        {
            Debug.LogWarning("UI script is null!");
        }

        instance = this;

    }

    public void AddKill()
    {
        killCounter++;
        uiScript.UpdateKillVal(killCounter);
    }

    public void TakeLife()
    {
        lifeCounter--;
        uiScript.UpdateLifeVal(lifeCounter);
    }
}
