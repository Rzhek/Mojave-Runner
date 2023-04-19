using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFeel : MonoBehaviour
{
    public static GameFeel instance;

    public float cameraShakeTime;

    void Awake()
    {
        if (instance) Destroy(this);
        else instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void AddCameraShake(float time)
    {
        if (instance)
        {
            instance.cameraShakeTime = time;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraShakeTime > 0f)
        {
            cameraShakeTime -= Time.deltaTime;
            Vector3 newCameraPosition = new Vector3();
            newCameraPosition.x = Random.Range(-.1f, .1f); 
            newCameraPosition.y = Random.Range(-.1f, .1f);
            newCameraPosition.z = -10; 
            Camera.main.transform.position = newCameraPosition;
        }
    }
}
