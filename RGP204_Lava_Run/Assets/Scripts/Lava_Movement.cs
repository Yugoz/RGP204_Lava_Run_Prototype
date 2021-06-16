using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava_Movement : MonoBehaviour
{
    public float speed = 2.0f;

    void Update()
    {

        transform.position += transform.up * speed * Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boost"))
        {
            speed += 0.5f;
        }

    }
}
