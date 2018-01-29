using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    public static string dog;
	// Use this for initialization
	void Start () {
        dog = "lol";
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(dog);
	}
}
