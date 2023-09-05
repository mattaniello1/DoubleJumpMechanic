using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpPowerup : MonoBehaviour
{
    public PlayerMovement jN;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        jN.JumpNum += 1;
    }
}
  