using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D backTire, frontTire, myRB;

    [SerializeField]
    private float fuel;

    [SerializeField]
    private float speed, carTorque, fuelComsuption;

    private float movement;


    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");

        if (fuel > 0)
        {
            fuel -= fuelComsuption * (Mathf.Abs(movement) * Time.deltaTime);
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