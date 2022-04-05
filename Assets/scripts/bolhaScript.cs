using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolhaScript : MonoBehaviour
{
    private float doubleY;
    void Start()
    {
        doubleY = this.transform.position.y + this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    }
}
