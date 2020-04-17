using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    public float speed;

    private Transform ennemyTrans;
    public GameObject ennemy;
    private Vector2 target;

    // Start is called before the first frame update
    void Start()
    {
        ennemyTrans = GameObject.FindGameObjectWithTag("Ennemy").GetComponent<Transform>();

        target = new Vector2(ennemyTrans.position.x, ennemyTrans.position.y);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

            if (transform.position.x == target.x && transform.position.y == target.y)
            {
                DestroyBullet();
            }
        
        

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ennemy"))
        {
            Debug.Log(other);
            Destroy(other.gameObject);
            //ennemy.SetActive(false);
            DestroyBullet();
        }
    }
    

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
