using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseScript : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(player.transform.position.x * Time.deltaTime,
            player.transform.position.y * Time.deltaTime,
            0);
    }
}
