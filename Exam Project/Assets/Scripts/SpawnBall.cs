using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ballPrefab;
    private float spawnRange = 50;
    public Score scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreScript.points >= 1000)
        {
            GameObject ball = Instantiate(ballPrefab, Vector3.zero, ballPrefab.transform.rotation);
        }
    }
}

