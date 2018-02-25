using UnityEngine;

public class PlayerBurns : MonoBehaviour
{
    public GameObject bulletGoad;
    public Transform bulletRally;
    public GameObject bulletEx;
    public Transform bulletWard;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            Flame();
        }
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Hell();
        }
    }

    void Flame()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletGoad,
            bulletRally.position,
            bulletRally.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 500;

        //Destroy the bullet after 7 seconds
        Destroy(bullet, 7.0f);
    }

    void Hell()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletEx,
            bulletWard.position,
            bulletWard.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 300;

        //Destroy the bullet after 7 seconds
        Destroy(bullet, 7.0f);
    }
}