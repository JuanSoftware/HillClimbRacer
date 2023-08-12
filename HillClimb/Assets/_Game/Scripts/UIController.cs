using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public TMP_Text txtDistance, txtCoins;

    private GameController gameController;

    [SerializeField]
    private Image imgFuel;
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

        UpdateImageFuel();
    }

    void UpdateImageFuel()
    {
        imgFuel.fillAmount = gameController.UpdateFuel();
    }
}
