using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float upForce = 2;
	public float horizontalForce = 2;

    bool isImmune = false;

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Mouse0)){

			bool leftSide = (Input.mousePosition.x <= Screen.width / 2);

            Vector2 currentVel = GetComponent<Rigidbody2D>().velocity;

			if (leftSide){

                if (currentVel.x > 0) GetComponent<Rigidbody2D>().velocity = new Vector2(0, currentVel.y);
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-horizontalForce, upForce));
                
			}
			else{
                if (currentVel.x < 0) GetComponent<Rigidbody2D>().velocity = new Vector2(0, currentVel.y);
				GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontalForce, upForce));
			}
		}
        
	}

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.relativeVelocity.y > 0)
        {
            LoseLife();
        }
        print(c.relativeVelocity);
    }

    void LoseLife()
    {
        if (isImmune) return;

        GameController.instance.TakeLife();
        StartCoroutine(LostLifeVisual());
    }

    IEnumerator LostLifeVisual()
    {
        isImmune = true;

        yield return new WaitForSeconds(.2f);
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(.2f);
        GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(.2f);
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(.2f);
        GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(.2f);
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(.2f);
        GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(.2f);

        isImmune = false;
    }
}
