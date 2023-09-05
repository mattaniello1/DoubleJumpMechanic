using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpControl : MonoBehaviour
{
    public float Timer = 5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        TimerTime();

        if (Timer == 0)
        {
            gameObject.SetActive(true);
            Timer = 5;
        }
    }
    void TimerTime()
    {
        Timer -= Time.deltaTime;
    }
}
