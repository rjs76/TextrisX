using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapemoving : MonoBehaviour
{
    public Vector3 RotationPoint;
    private float previousTime;
    public float fallTime=0.8f;
    //making it static for same variable for all blocks
    public static int height = 15;
    public static int width = 12;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            //checking valid position every move
            if (Validmoving())
            {
                transform.position -= new Vector3(-1, 0, 0);
            }

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            //checking valid position every move
            if (Validmoving())
            {
                transform.position -= new Vector3(1, 0, 0);
            }  

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //rotate
            transform.RotateAround(transform.TransformPoint(RotationPoint),new Vector3(0,0,1), 90);
            if (Validmoving())
                transform.RotateAround(transform.TransformPoint(RotationPoint), new Vector3(0, 0, 1), -90);
        }


        //if we return the down key then it reduce the time otherwise it will return the falltime
        if (Time.time - previousTime > (Input.GetKey(KeyCode.DownArrow)? fallTime/10: fallTime))
        {
            transform.position += new Vector3(0, -1, 0);
            //checking valid position every move
            if (Validmoving())
            {
                transform.position -= new Vector3(-1, 0, 0);
            }

            previousTime = Time.time;
        }
    }

    bool Validmoving()
    {
        foreach(Transform children in transform) //browse through the chrildren
        {
            int roundedX = Mathf.RoundToInt(children.transform.position.x);
            int roundedY = Mathf.RoundToInt(children.transform.position.y);

            if (roundedX < 0 || roundedX >= width || roundedY < 0 || roundedY > height)
            {
                return false;
            }


        }
        return true;
    }


}
