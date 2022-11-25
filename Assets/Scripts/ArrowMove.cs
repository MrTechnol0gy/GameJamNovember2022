using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{

    public float speed;
    public float rotation;

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.right * speed * Time.deltaTime; //Move forwards according to angle
        transform.Rotate(0, 0, Input.GetAxis("Vertical") * rotation * Time.deltaTime);      //
        
    }
}
