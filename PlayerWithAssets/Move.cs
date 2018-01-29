
using UnityEngine;
using System.Collections;
public class Move : MonoBehaviour
{ 
    public Vector3 speed = new Vector3(0, 0, 5.0F);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= 15)
        {
            Destroy(gameObject);
        }
        transform.Translate(speed * Time.deltaTime);
    }
}