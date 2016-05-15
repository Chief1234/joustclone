using UnityEngine;
using System.Collections;

public class BadGuy : MonoBehaviour {

    public float horizontalSpeed = 3;

	// Update is called once per frame
	void Update () {

        Vector3 currentPos = transform.position;
        transform.position = currentPos + new Vector3(horizontalSpeed * Time.deltaTime, 0, 0);

        if (Time.timeSinceLevelLoad > .2f)
            if (!GetComponent<SpriteRenderer>().isVisible) Destroy(gameObject);
	}
}
