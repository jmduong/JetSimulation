using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPosition : MonoBehaviour {

    public float y;
    public string text;

	// Update is called once per frame
	void Update () {
        y = gameObject.transform.position.y;
        GetComponent<TextMeshPro>().text = "Elevation Level: " + y;
    }
}
