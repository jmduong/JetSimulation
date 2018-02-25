using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ElevationLevel : MonoBehaviour {

    public TextMeshPro elevation;

    // Update is called once per frame
    void Update () {
        var y = gameObject.transform.position.y;
        elevation.text = "Elevation Level: " + y;
    }
}