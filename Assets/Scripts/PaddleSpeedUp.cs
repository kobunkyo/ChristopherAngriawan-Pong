using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpeedUp : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D paddle;
    public Collider2D ball;
    public float multiplayer;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision == ball)
        {
            paddle.GetComponent<PaddleController>().ActivatePaddleSpeed(multiplayer);
            Debug.Log("Speed Up Confirm!");
            manager.RemovePowerUP(gameObject);
        }
    }
}
