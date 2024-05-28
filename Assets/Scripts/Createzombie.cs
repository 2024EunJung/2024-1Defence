using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Createzombie : MonoBehaviour
{
    public GameObject prefabzombie;

    public Vector2 limitMin;
    public Vector2 limitMax;
    private float delay;
    private int count;

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
            count++;

            float r = Random.Range(limitMin.y, limitMax.y);
            Vector2 creatingPoint = new Vector2(limitMin.x, r);

            Instantiate(prefabzombie, creatingPoint, Quaternion.identity);

            delay = 10.0f / (count =1);
            yield return new WaitForSeconds(delay);
        }
    }
    

    


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(limitMin, limitMax);
    }
}
