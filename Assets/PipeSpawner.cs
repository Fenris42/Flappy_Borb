using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;
    public float SpawnRate;
    private float timer = 0;
    public float pipeOffset;


    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer = timer + Time.deltaTime;

        }
        else
        {
            spawnPipe();
            timer = 0;

        }

        

    }

    void spawnPipe()
    {
        float lowPoint = transform.position.y - pipeOffset;
        float hightPoint = transform.position.y + pipeOffset;

        Instantiate(Pipes, new Vector3(transform.position.x, Random.Range(lowPoint, hightPoint), 0), transform.rotation);
    }
}
