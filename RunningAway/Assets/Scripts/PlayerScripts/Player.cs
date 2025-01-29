using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    private float directionX = 0;
    private float directionY = 0;
    [SerializeField] private int health = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        directionX = Input.GetAxis("Horizontal");
        directionY = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(directionX, directionY, 0);

        transform.Translate(direction*speed*Time.deltaTime);
        Debug.Log(direction * speed * Time.deltaTime);
        Debug.Log(health);

    }
}
