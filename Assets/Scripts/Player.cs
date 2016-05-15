using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float upForce = 2;
	public float horizontalForce = 2;
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Space)){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, upForce));
		}

		if (Input.GetKey(KeyCode.LeftArrow)){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-horizontalForce, 0));
		}

		if (Input.GetKey(KeyCode.RightArrow)){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontalForce, 0));
		}
	}
}
