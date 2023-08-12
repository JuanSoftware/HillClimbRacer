using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    [SerializeField]
    private Transform startPoint, endPoint;

    public int curretScore;

    public bool gasBtnPressed, brakeBtnPressed, gameOver;

    public GameObject fuelWarning;
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

    public IEnumerator GameOver()
    {
        gameOver = true;
        if (gameOver)
        {
            gasBtnPressed = false;
            brakeBtnPressed = false;
            fuelWarning.SetActive(false);

            //panel gameover
        }

        yield return new WaitForSeconds(4f);
        fuelWarning.SetActive(false);

        //panel gameover

        yield return new WaitForSeconds(8f);
        string name = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(name);
    }
}
