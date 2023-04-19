using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Rigidbody2D rb;
    public Parallax.Layer layer;
    public float destroyBorder = -10;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.position += Vector3.left * Parallax.GetSpeed(layer) * Time.deltaTime;

        if (transform.position.x < - 10)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Health.TryDamageTraget(other.gameObject, 1);
    }
}
