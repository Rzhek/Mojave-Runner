using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax
{
    public static float speed = 6f;
    public enum Layer
    {
        Foreground, Midground, Background
    }

    public static float GetSpeed(Layer layer)
    {
        switch (layer)
        {
            case Layer.Foreground:
                return speed * 1.5f;
            case Layer.Midground:
                return speed * 1f;
            case Layer.Background:
                return speed * .5f;
            default:
                return speed;
        }
    }
}

public class ParallaxLayer : MonoBehaviour
{
    public Transform[] tiles;
    public float left = -19f;
    public Vector3 right = new Vector3(19f, -1f, 0f);
    public Parallax.Layer layer;

    void Start()
    {
        
    }


    void Update()
    {
        for (int i =0; i < tiles.Length; i++)
        {
            tiles[i].position += Vector3.left * Time.deltaTime * Parallax.GetSpeed(layer);

            if (tiles[i].position.x <= left)
            {
                tiles[i].position = right;
            }
        }
    }
}
