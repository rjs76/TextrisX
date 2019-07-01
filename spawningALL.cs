using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningALL : MonoBehaviour
{
    public GameObject[] blockT;

    // Start is called before the first frame update
    void Start()
    {
        NewTetromino();
    }

    public void NewTetromino()
    {
        Instantiate(blockT[Random.Range(0, blockT.Length)], transform.position, Quaternion.identity);
    }
}
