using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D backTire, frontTire, myRB;

    public float fuel;

    [SerializeField]
    private float speed, carTorque, fuelComsuption;

    private float movement;

    private GameController gameController;


    private void Awake()
    {
        gameController = FindObjectOfType<GameController>();
    }
    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");

        if (fuel > 0)
        {
            fuel -= fuelComsuption * (Mathf.Abs(movement) * Time.deltaTime);
        }

        if(movement != 0f)
        {
            gameController.gasBtnPressed = true;
        }
        else
        {
            gameController.gasBtnPressed = false;
        }

        if (fuel <= 0.25 && !gameController.gameOver)
        {
            gameController.fuelWarning.SetActive(true);
        }

        if(fuel <= 0f && gameController.gameOver)
        {
            StartCoroutine(gameController.GameOver());
        }
    }

    private void FixedUpdate()
    {
        if (fuel > 0)
        {
            backTire.AddTorque(-movement * (speed * Time.fixedDeltaTime));
            frontTire.AddTorque(-movement * (speed * Time.fixedDeltaTime));
            myRB.AddTorque(-movement * (carTorque * Time.fixedDeltaTime));
        }
    }
}