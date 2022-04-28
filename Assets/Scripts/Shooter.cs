using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectile;
    public float power = 50.0f;

    public AudioClip shootSFX;


    void Update()
    {

        if(Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump")){
            if (projectile)
            {
                GameObject nProjectile = Instantiate(projectile, transform.position +
                    transform.forward, transform.rotation) as GameObject;

                if (!nProjectile.GetComponent<Rigidbody>())
                {
                    nProjectile.AddComponent<Rigidbody>();
                }

                nProjectile.GetComponent<Rigidbody>().AddForce(
                    transform.forward * power, ForceMode.VelocityChange);

                if (shootSFX)
                {
                    if (nProjectile.GetComponent<AudioSource>())
                    {
                        nProjectile.GetComponent<AudioSource>().PlayOneShot(shootSFX);
                    }
                    else
                    {
                        AudioSource.PlayClipAtPoint(shootSFX, nProjectile.transform.position);
                    }
                }
            }      
        }    
    }
}
