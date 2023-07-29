using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    [SerializeField]
    private Transform startPoint, endPoint;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Start()
    {
        player.transform.position = startPoint.position;
        CalculateDistance();
        CalculatePlayerDistance();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float CalculateDistance()
    {
        float distance = Vector3.Distance(startPoint.position, endPoint.position);
        return distance;
    }

    public float CalculatePlayerDistance()
    {
        float distancia = player.transform.position.x - startPoint.position.x;
        return distancia;
    }
    public float UpdateFuel()
    {
        float fuel = player.GetComponent<VehicleController>().fuel;

        return fuel;
    }
}
