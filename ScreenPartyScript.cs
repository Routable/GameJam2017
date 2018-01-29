using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPartyScript : MonoBehaviour {
    private Animator anim;
    private int time = 0;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        time++;

        if (time % 50 == 0)
            anim.SetBool("Switch", true);
        if(time % 100 == 0)
        {
            anim.SetBool("Switch", false);
        }

		
	}
}
