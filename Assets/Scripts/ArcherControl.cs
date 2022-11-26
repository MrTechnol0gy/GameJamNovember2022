using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherControl : MonoBehaviour
{
    public GameObject bow;
    public GameObject arrow;
    bool pulled;
    bool fired;
    bool goingUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") != 0)
        {
            pulled = true;
        }

        if (pulled == true && Input.GetAxis("Vertical") == 0 && fired == false)
        {
            GameObject.Instantiate(arrow,bow.transform);
            fired = true;
            Debug.Log("Fire!");
        }

    }
}
