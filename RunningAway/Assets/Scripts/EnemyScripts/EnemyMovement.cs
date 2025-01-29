using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    //set the values in the inspector
    public Transform target; //drag and stop player object in the inspector
    public float speed;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update(){
        ChasePlayer();
        CheckCollision();
    }


    void CheckCollision()
    {
        
    }


    void ChasePlayer()
    {
        //get the distance between the player and enemy (this object)
        float dist = Vector2.Distance(transform.position, player.transform.position);

        Vector2 direction = player.transform.position - transform.position;

        //move to target(player) 
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed*Time.deltaTime);
    }
}



