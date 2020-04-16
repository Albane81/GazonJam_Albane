using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawEnnemi : MonoBehaviour
{
    [SerializeField]private GameObject[] TaupeSpawn;
    [SerializeField] private float TimeSpawn = 10f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTaupe",3,TimeSpawn);
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
        Instantiate(TaupeSpawn[Random.Range(0, 1)], RandomPos(), Quaternion.identity);
        //Debug.Log("Instantiate");
    }
}
