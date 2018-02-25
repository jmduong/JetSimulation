using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);                   //Which?
        Vector3 enemy = target.transform.position;
        float x = (enemy.x) - transform.position.x;
        float y = (enemy.y) - transform.position.y;
        float z = (enemy.z) - transform.position.z;
        float total = x + y + z;
        x = x / total;
        y = y / total;
        z = z / total;
        Vector3 march = new Vector3(x, y, z);
        transform.Translate(march * 30 * Time.deltaTime);
        Debug.DrawRay(transform.position,Vector3.forward,Color.black);
    }
}