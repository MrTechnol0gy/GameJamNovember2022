using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{

    public float speed;
    public float rotation;
    public string obstacleTag;
    public string targetTag;

    Rigidbody2D rb;
    float angle;
    bool canMove = true;

    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            transform.position = transform.position + transform.right * speed * Time.deltaTime;     //Move forwards

            transform.Rotate(0, 0, Input.GetAxis("Vertical") * rotation * Time.deltaTime);  //Angle Arrow
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == obstacleTag)
        {
            canMove = false;
        }
    }

}
