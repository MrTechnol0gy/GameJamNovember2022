using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCode : MonoBehaviour
{
    public string playerTag;
    public string obstacleTag;
    public string UITag;
    public GameObject sprite;
    public ParticleSystem explodeParticles;
    public ParticleSystem bloodParticles;
    public int maxDeathThings;
    public Rigidbody2D[] rbs;
    public GameObject spawner1;
    public GameObject spawner2;
    public int value;
    public GameObject UI;

    int choice;
    BoxCollider2D col;
    bool toTriple = false;
    bool alive = true;

    private void Awake()
    {
        col = gameObject.GetComponent<BoxCollider2D>();
        UI = GameObject.FindGameObjectWithTag(UITag);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == obstacleTag && toTriple == true)
        {
            toTriple = false;
            GameObject.Instantiate(gameObject, spawner1.transform);
            spawner1.GetComponentInChildren<TargetCode>().BlobAbout();
            GameObject.Instantiate(gameObject, spawner2.transform);
            spawner2.GetComponentInChildren<TargetCode>().BlobAbout();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == playerTag && alive == true)
        {

            choice = Random.Range(0, maxDeathThings);
            if (choice == 0)
            {
                BlobAbout();
            }
            else if (choice == 1)
            {
                Explode();
            }
            else if (choice == 2)
            {
                Triple();
            }

            alive = false;

            UI.GetComponent<UIScript>().AddScore(value);

        }
    }

    void BlobAbout()
    {
        alive = false;
        foreach (Rigidbody2D rb in rbs)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
        col.size = new Vector2(2, 2);
        bloodParticles.Play();
    }

    void Explode()
    {
        sprite.SetActive(false);
        col.enabled = false;
        explodeParticles.Play();
    }

    void Triple()
    {
        toTriple = true;
        BlobAbout();
    }


}
