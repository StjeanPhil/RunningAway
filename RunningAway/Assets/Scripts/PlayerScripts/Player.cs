using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 8;
    private float directionX = 0;
    private float directionY = 0;
    [SerializeField] private static GameObject map;
    //float mapHeight = map.scale.Y;
    //float mapLength = map.scale.X;
    [SerializeField] private Rigidbody2D body;

    



    [SerializeField] private int health = 10;
    // Start is called before the first frame update
    void Start()
    {
        //mapHeight = map.transform.scale.Y;
        //mapLength = map.transform.scale.X;
    }       

    // Update is called once per frame
    void Update()
    {
        Movement();

    }
    void Movement()
    {
              
        directionX = Input.GetAxis("Horizontal");
        directionY = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(directionX, directionY);

    
        body.velocity = direction * speed ;


    }   
}