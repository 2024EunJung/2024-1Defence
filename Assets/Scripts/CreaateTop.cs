using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class CreaateTop : MonoBehaviour
{
    public GameObject prefabTop;
    public static int top = 0;

    public Vector2 limitMin;
    public Vector2 limitMax;

    private float delay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Create());
    }
        
    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Create()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Space) == true)
            {
                float a = UnityEngine.Random.Range(limitMin.x, limitMax.x);
                float r = UnityEngine.Random.Range(limitMin.y, limitMax.y);
                Vector2 creatingPoint = new Vector2(a, r);
                Upgrade.kill -= 10;

                Instantiate(prefabTop, creatingPoint, Quaternion.identity);
                delay = 0.5f;
            }

            if (Input.GetKey(KeyCode.K) == true)
            {
                Upgrade.kill += 1;
            }
            yield return new WaitForSeconds(delay);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(limitMin, limitMax);
    }
}
