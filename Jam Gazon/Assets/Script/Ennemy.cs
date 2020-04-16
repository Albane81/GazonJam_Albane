using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;

    private float TimeShots;
    public float startTimeShots;

    public GameObject bullet;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            
            //Debug.Log(transform.position);
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }else if (Vector2.Distance(transform.position,player.position) < stoppingDistance)

        {
            transform.position = this.transform.position;

        }

        if(TimeShots <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            TimeShots = startTimeShots;
        }
        else
        {
            TimeShots -= Time.deltaTime;
        }
    }

    
}
