using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePickUp : MonoBehaviour
{
    public string playerTag;
    public string UITag;
    public float value;
    public GameObject UI;
    AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
        UI = GameObject.FindGameObjectWithTag(UITag);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == playerTag)
        {
            UI.GetComponent<UIScript>().AddTime(value);
            gameObject.SetActive(false);
        }
    }


}
