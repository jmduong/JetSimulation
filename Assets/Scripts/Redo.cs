using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        // returns true if the primary button (typically “A”) is currently pressed.
        if(OVRInput.Get(OVRInput.Button.One))
        {
            SceneManager.LoadScene("Controller");
        }
    }
}
