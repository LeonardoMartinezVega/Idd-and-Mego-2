/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public GameObject SpawnPoint;
    public GameObject Iddy;

    // Start is called before the first frame update
    void Start()
    {
        Iddy = GameObject.FindObjectWithTag("Player");
        SpawnPoint = GameObject.FindObjectWithTag("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Iddy.transform.position = SpawnPoint.transform.position;
        }
    }
}*/