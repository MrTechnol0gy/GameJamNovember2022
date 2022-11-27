using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherControl : MonoBehaviour
{
    public GameObject bow;
    public GameObject arrow;
    public float rotationSpeed;
    public float maxAngle;
    bool pulled;
    bool fired;
    float dir = 1;
    AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        aud = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") != 0)
        {
            pulled = true;
        }

        if (pulled == true && fired == false)
        {
            if (Input.GetAxis("Vertical") == 0)                 //
            {                                                   //
                GameObject.Instantiate(arrow, bow.transform);   //  Fire Arrow when release
                fired = true;                                   //
                aud.Play();                                     //
            }                                                   //

            if(bow.transform.eulerAngles.z >= maxAngle && bow.transform.eulerAngles.z <= 360 - maxAngle)    //
            {                                                                                               //  Change direction
                dir = dir * -1;                                                                             //
            }                                                                                               //

            bow.transform.RotateAround(gameObject.transform.position, Vector3.forward, rotationSpeed * dir * Time.deltaTime);   //  Rotate Bow
        }
    }
}
