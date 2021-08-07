using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFiring : MonoBehaviour
{
    public GameObject bulletToRight, bulletToLeft;
    float fireRate = 0.5f, nextFire;
    Vector2 bulletPos;
    int ammoAmount;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            fire();
        }
        
    }
    void fire()
    {
        bulletPos = transform.position;
        if (PlayerController.isfacingRight)
        {
            bulletPos += new Vector2(1, -0.33f);
            Instantiate(bulletToRight, bulletPos, Quaternion.identity);
        }
        else
        {
            bulletPos += new Vector2(-1, -0.33f);
            Instantiate(bulletToLeft, bulletPos, Quaternion.identity);
        }
      


    }
}
