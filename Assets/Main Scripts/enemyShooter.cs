using UnityEngine;
using System.Collections;

public class enemyShooter : MonoBehaviour
{
    Transform me;
    public Transform player;
    Vector3 distance;

    public Rigidbody bullet;

    bool canShoot = false;
    float shootTime = 25.0F;
    int bulletSpeed = 5;
    public int enemySight = 35;

    // Use this for initialization
    void Start ()
    {
        me = this.GetComponent<Transform>();

        bullet = bullet.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        distance = (me.position - player.position);

        if (distance.magnitude < enemySight)
            canShoot = true;
        else
            canShoot = false;

        if (canShoot && shootTime <= 0.1F)
        {
            PewPew();
        }

        
    }

    void FixedUpdate()
    {
        minusTime();
    }

    void PewPew()
    {
        Rigidbody clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
        clone.velocity = transform.TransformDirection(Vector3.right) * bulletSpeed;

        shootTime = 25.0F;
    }

    void minusTime()
    {
        if (shootTime > 0)
            shootTime -= 0.1F;
        else
            shootTime = 0.0F;
    }
}
