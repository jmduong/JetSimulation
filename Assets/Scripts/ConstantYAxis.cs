using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantYAxis : MonoBehaviour {

    public Transform player;

    // Update is called once per frame
    void Update () {
        var x = player.position.x;
        var z = player.position.z;
        transform.position = new Vector3(x, 0, z);
    }
}
