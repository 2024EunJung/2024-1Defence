using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chong : MonoBehaviour
{
    private float lifetime = 5f;
    private float spawnTime;
    private float delay;
    private float speed = 30;


    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, -90);
        spawnTime = Time.time;
        delay = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - spawnTime > lifetime)
        {
            Destroy(gameObject);
            spawnTime = Time.time;
        }
        this.transform.Translate(Vector3.up * this.speed * Time.deltaTime);
    }
}
