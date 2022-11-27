using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{

    public float speed;
    public float rotation;
    public string obstacleTag;
    public string targetTag;
    public string UITag;
    public string gameControllerTag;
    public GameObject UI;
    public GameObject gameController;
    public float tempPos;

    AudioSource aud;
    Rigidbody2D rb;
    float angle;
    bool canMove = true;

    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        UI = GameObject.FindGameObjectWithTag(UITag);
        gameController = GameObject.FindGameObjectWithTag(gameControllerTag);
        transform.parent = null;
        tempPos = transform.position.x;
        aud = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            transform.position = transform.position + transform.right * speed * Time.deltaTime;     //Move forwards

            transform.Rotate(0, 0, Input.GetAxis("Vertical") * rotation * Time.deltaTime);  //Angle Arrow

            if(transform.position.x > tempPos)
            {
                UI.GetComponent<UIScript>().AddDist(transform.position.x - tempPos);
                tempPos = transform.position.x;
            }
        }
        else if(aud.isPlaying == false)
        {
            gameController.GetComponent<ScoreContainerScript>().EndLevel();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == obstacleTag)
        {
            canMove = false;
            rb.bodyType = RigidbodyType2D.Static;
            aud.Play();
        }
    }


}
