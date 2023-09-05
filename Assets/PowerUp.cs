using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float Timer = 5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TimerTime();
        gameObject.SetActive(false);
        

        if (Timer == 0)
        {
            gameObject.SetActive(true);
        }
    }
    private void TimerTime()
    {
        Timer -= Time.deltaTime;

        if(Timer == 0)
        {
            Timer = 5;
        }
    }
}
