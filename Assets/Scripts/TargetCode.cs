using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCode : MonoBehaviour
{
    public string playerTag;
    public GameObject sprite;
    public ParticleSystem explodeParticles;
    public ParticleSystem bloodParticles;
    public int maxDeathThings;


    int choice;
    Collider2D col;

    private void Awake()
    {
        col = gameObject.GetComponent<Collider2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == playerTag)
        {
            /*
            choice = Random.Range(0,maxDeathThings);
            if(choice == 0)
            {

            }
            */
            Explode();
        }
    }

    void BlobAbout()
    {

    }

    void Explode()
    {
        sprite.SetActive(false);
        col.enabled = false;
        explodeParticles.Play();
    }

    void Triple()
    {

    }


}
