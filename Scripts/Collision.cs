using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    public Transform wave;
    private bool canBeHit = true;
    private int health = 3;
    public int invulnerable = 3;
	void Start () {
		
	}

    // Update is called once per frame
    private void Update()
    {
        CrowdMovement crowd = new CrowdMovement();

        if (!canBeHit)
        {
            invulnerable -= Time.captureFramerate;
            if (invulnerable <= 0)
            {
                canBeHit = true;
                invulnerable = 3;
                crowd.playerHit();
            }
        }
    }
 private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("Hit");
        if (canBeHit == true)
        {
            if (collision.gameObject.name == "Wave")
            {
                Debug.Log(health);
                Destroy(collision.gameObject);
                canBeHit = false;
              health--;
            }
        }
    }
    
}
