using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CreaateTop : MonoBehaviour
{
    public static int top = 0;
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
            if (Input.GetKeyDown(KeyCode.Space) )
            {
                int top = 1;
                Debug.Log("test");
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}
