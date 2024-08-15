using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    // Life means the object's lifetime in Secs 
    private void Awake()
    {
        Destroy(gameObject,life);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
