using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAdapter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private EdgeCollider2D[] grounds;
    void Start()
    {
        grounds = GetComponentsInChildren<EdgeCollider2D>();
        float tempTransform = grounds[0].bounds.size.x;

        for (int i = 0;i<grounds.Length; i++)
        {
            grounds[i].gameObject.transform.position = new Vector2(tempTransform * i, transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
