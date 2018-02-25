using UnityEngine;

public class PlayerFirearm : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            Fire();
        }
    }


    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 300;

        //Destroy the bullet after 7 seconds
        Destroy(bullet, 7.0f);
    }
}