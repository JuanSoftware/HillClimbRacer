using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text txtDistance;

    private GameController gameController;
    // Start is called before the first frame update

    private void Awake()
    {
        gameController = FindObjectOfType<GameController>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtDistance.text = gameController.CalculatePlayerDistance().ToString("0") + " / " + gameController.CalculateDistance().ToString("0");
    }
}
