using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    [SerializeField] private int health = 10;
    [SerializeField] private int damage = 1;

    [SerializeField] private GameObject gemPrefab;
    
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update ()
    {
       ChasePlayer();
    }

    void ChasePlayer()
    {
        //get the distance between the player and enemy (this object)
        float dist = Vector2.Distance(transform.position, player.transform.position);

        Vector2 direction = player.transform.position - transform.position;

        //move to target(player) 
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed*Time.deltaTime);

    }

    // on collision with player, deal damage to player
    // destroy self

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Player>().TakeDamage(this.damage);
            Death();
        }
    }

    void Death()
    {

        Destroy(this.gameObject);

        // Drop a gem
        Instantiate(gemPrefab, transform.position, Quaternion.identity);
    }
}
