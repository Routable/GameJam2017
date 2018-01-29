using UnityEngine;
using System.Collections;

public class CrowdMovement : MonoBehaviour
{

    public Vector3 Vector = Vector3.up;
    


    //set to false to disable movement - we can link this to scoring to make crowd look bored
    public bool crowdMove = true;


    
    //Change these to effect movement of sprites. Range applies vertical positioning (up/down), while speed will affect the frequency of movement. 
    public float Range = 0.2f; 
    public float Speed = 10f; 

    //start method ---------------------------------------------------------------------------------------------------------------------------->
    private CrowdMovement crowdmovement; 
    Vector3 start;

     
    void Start()
    {
        crowdmovement = this;
        start = crowdmovement.transform.position;
    }

    void Update()
    {


 
        
        if (crowdMove)
        {
            crowdmovement.transform.position = start + Vector * (Range * Mathf.Sin(Time.timeSinceLevelLoad * Speed));
        }
        
        
    }



    //when called on, doubles movement speed of crowd
   void getActive()
        {
       Speed = Speed * 2; 
        }



    //when called on, halfs movement speed of crowd
   void getLessActive()
        {
        Speed = Speed / 2; 
        }


    public void playerHit()
    {

        transform.Translate(new Vector3(0, (float)-0.1, 0));
        // int crowd = Random.Range(0, 100);

        /*   if (crowd > 70)
           {
               //Range = Range - (float)0.1;
               transform.Translate(new Vector3(0, (float)-0.1, 0));
           }
           */
    }

    void playerGood()
    {

        if(transform.position.y < -4.0f)
        {
            transform.Translate(new Vector3(0, (float)0.1, 0));

        }
      

    }


 
}