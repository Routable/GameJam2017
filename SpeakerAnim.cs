using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerAnim : MonoBehaviour {

    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        
  
        if (WaveSpawner.color == 1)
        {
            anim.SetTrigger("redShoot");
        }
        if (WaveSpawner.color == 2)
        {
            anim.SetTrigger("blueShoot");
        }
        if (WaveSpawner.color == 3)
        {
            anim.SetTrigger("greenShoot");
        }
        else
            anim.SetTrigger("noneShoot");
    }
}
