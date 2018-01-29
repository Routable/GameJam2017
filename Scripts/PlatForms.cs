using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatForms : MonoBehaviour {

 
    public float speed = 1.0f;
    public float startPos = -4;
    public float endPos = 4;
    
    private void Update()
    {
        transform.position = new Vector3(PingPong(Time.time * speed,startPos, endPos), transform.position.y, transform.position.z);
    }
    float PingPong(float t, float minLength, float maxLength)
    {
        return Mathf.PingPong(t, maxLength - minLength) + minLength;
    }

    private void OnTriggerEnter2D(Collider2D  other)
    {
      //  other.isTrigger = false;
       // Debug.Log("ok");
      
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }
}
