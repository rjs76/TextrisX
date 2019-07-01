using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public GameObject first;
    public KeyCode key1;
    public float speed=5f;
    public bool collide;
    public spawn spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        first = spawner.lastSpawned;

            if (Input.GetKeyDown(key1) && collide==false)
            {
                first.transform.Rotate(0, 0, 90);
            }

    }
    /**
     void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "gamebar")
        {
            collide = true;
            Debug.Log("Do something here");
        }
        else 
        {
            collide = false;
        }

    }
    */
    
     void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "gamebar")
        {
            collide = true;
            Debug.Log("Do something here");
        }
        else
        {
            collide = false;
        }

    }
    
}
