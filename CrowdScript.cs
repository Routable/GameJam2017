using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdScript : MonoBehaviour
{
    System.Random random = new System.Random();



    float pos = 0f;



    void Start()
    {

    }



    void Update()
    {



        int randomNumber = random.Next(0, 100);


        CrowdMovement crowd = new CrowdMovement();

        if (pos <= 30 && randomNumber > 95)
        {
            transform.Translate(new Vector3(0, 0.1f, 0));
            pos++;

        }



    }
}