using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour {

    public float timeleft;

	// Use this for initialization
	void Start () {
        timeleft = 1200;
	}
	
	// Update is called once per frame
	void Update () {
        if(timeleft >=0)
        {
            timeleft -= Time.deltaTime;
            GetComponent<TextMeshPro>().text = "Time Left: " + timeleft + " seconds.";
        }
    }
}