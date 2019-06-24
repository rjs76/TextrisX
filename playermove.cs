using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public GameObject first;
    public KeyCode key1;
    public float speed=5f;
    public bool collide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(key1) && collide==false)
            {
                first.transform.Rotate(0, 0, 90);
            }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "gamebar")
        {
            collide = true;
        }
        else 
        {
            collide = false;
        }

    }
}
