using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawEnnemi : MonoBehaviour
{
    public GameObject taupeSpawn;
    //public GameObject Ennemy;
    [SerializeField] private float TimeSpawn;
    [SerializeField] private float DelaySpawn;
    private static int ennemy;


    // Start is called before the first frame update
    void Start()
    {
        ennemy = 0;
        InvokeRepeating("SpawnTaupe",TimeSpawn,DelaySpawn);
    }

    void Update()
    {
        if(ennemy >= 3)
        {
            CancelInvoke("SpawnTaupe");
        }
    }

    Vector2 RandomPos()
    {
        float X = Random.Range(-8, 9);
        float Y = Random.Range(6,-10);

        Vector2 newPos = new Vector2(X, Y);
        return newPos;

    }

    void SpawnTaupe()
    {
        Instantiate(taupeSpawn, RandomPos(), Quaternion.identity);
        ++ennemy;
        //Debug.Log("Instantiate");
    }
}
