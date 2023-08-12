using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Ground"))
        {
            GameController tempGameController = FindObjectOfType<GameController>();
            tempGameController.gameOver = true;
        }
    }
}
