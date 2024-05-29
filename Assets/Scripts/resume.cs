using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resume : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        pause.IsPause = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stopped()
    {
        if (pause.IsPause == true)
        {
            Time.timeScale = 1;
            pause.IsPause = false;
            return;
        }

    }
}
