using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Image timerbar;
    public float maxTime = 5f;
    float timeleft;
    public GameObject LevelupText;



    // Start is called before the first frame update
    void Start()
    {
        LevelupText.SetActive(false);
        timerbar = GetComponent<Image>();
        timeleft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            timerbar.fillAmount = timeleft / maxTime;
        }
        else
        {
            LevelupText.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
