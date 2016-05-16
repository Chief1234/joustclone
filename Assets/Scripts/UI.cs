using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public Text killValue;
    public Text lifeValue;

    public void UpdateKillVal(int newVal)
    {
        killValue.text = newVal.ToString();
    }

    public void UpdateLifeVal(int newLife)
    {
        lifeValue.text = newLife.ToString();
    }
}
