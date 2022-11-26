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
    public Rigidbody2D[] rbs;
    public int force;

    int choice;
    Collider2D col;
    bool toTriple = false;

    private void Awake()
    {
        col = gameObject.GetComponent<BoxCollider2D>();
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
            //Explode();
            BlobAbout(collision);
        }
    }

    void BlobAbout(Collision2D collision)
    {
        foreach (Rigidbody2D rb in rbs)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
        col.isTrigger = true;
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
