using UnityEngine;
using System.Collections;

public class BadGuyMaker : MonoBehaviour {

    public float minDelay;
    public float maxDelay;

    public GameObject badguyPrefab;

    float activeDelay = 0;
    float delayCounter = 0;

    void Update()
    {

        if (delayCounter <= 0)
        {
            delayCounter = Random.Range(minDelay, maxDelay);
            MakeBadGuy();
        }
        
        delayCounter -= Time.deltaTime;
    }

    private void MakeBadGuy()
    {
        GameObject.Instantiate(badguyPrefab, new Vector3(-8, Random.Range(-3, 5), 0), Quaternion.identity);
    }
}
