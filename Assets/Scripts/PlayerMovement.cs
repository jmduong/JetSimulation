using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        var z = 1.0f;

        if (Input.GetAxis("Horizontal") != 0)
        {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            var y = Input.GetAxis("Vertical") * Time.deltaTime * 50.0f;
            transform.Rotate(0, x, 0);
            transform.Rotate(-y, 0, 0);
            transform.Translate(0, 0, z);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            var y = Input.GetAxis("Vertical") * Time.deltaTime * 50.0f;
            transform.Rotate(0, x, 0);
            transform.Rotate(-y, 0, 0);
            transform.Translate(0, 0, z);
        }
        else
        {
            var x = 0.0f;
            var y = 0.0f;
            transform.Rotate(0, x, 0);
            transform.Rotate(-y, 0, 0);
            transform.Translate(0, 0, z);
        }
    }
}