using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePickUp : MonoBehaviour
{
    public string playerTag;
    public float value;
    public GameObject UI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == playerTag)
        {
            UI.GetComponent<UIScript>().AddTime(value);
            gameObject.SetActive(false);
        }
    }


}
