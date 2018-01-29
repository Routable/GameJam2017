using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public Vector3 speed = new Vector3(0, 0, 5.0F);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime);
        if (transform.position.x >= 11.5)
        {
            Destroy(gameObject);
        }
       
    }
}