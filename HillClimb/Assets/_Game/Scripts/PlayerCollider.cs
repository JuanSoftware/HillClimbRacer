using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("EndPoint"))
        {
            Debug.Log("Voce venceu!");
            target.gameObject.SetActive(false);
        }
        else if (target.gameObject.CompareTag("Coin"))
        {
            GameController tempGameController = FindObjectOfType<GameController>();
            tempGameController.curretScore += target.GetComponent<Coin>().value;
            target.gameObject.SetActive(false);

            UIController tempUIController = FindObjectOfType<UIController>();
            tempUIController.txtCoins.text = tempGameController.curretScore.ToString();
        }
    }
}
