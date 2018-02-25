using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Redo : MonoBehaviour {

    public bool alive = true;

	// Use this for initialization
	void Start () {
		
	}

    void OnDestroy()
    {
        SceneManager.LoadScene("GameIsOver");
    }
}
