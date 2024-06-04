using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class CreaateTop : MonoBehaviour
{
    public GameObject prefabTop;
    public GameObject prefabTop1;
    public GameObject prefabTop2;
    public static int top = 0;

    public Vector2 limitMin;
    public Vector2 limitMax;

    private float delay;

    SpriteRenderer spriteRenderer;

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

                if (Upgrade.level == 2 || Upgrade.level == 1)
                {
                    Instantiate(prefabTop, creatingPoint, Quaternion.identity);
                }
                else if (Upgrade.level == 3)
                {
                    Instantiate(prefabTop1, creatingPoint, Quaternion.identity);
                }
                else if (Upgrade.level == 4)
                {
                    Instantiate(prefabTop2, creatingPoint, Quaternion.identity);
                }
                delay = 0.5f;
            }

            if (Input.GetKey(KeyCode.K) == true)
            {
                Upgrade.kill += 5;
                delay = 0.1f;
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
