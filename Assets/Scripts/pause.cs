using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour { 

    public static bool IsPause;


    // Start is called before the first frame update
    void Start()
    {
        IsPause = false;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Stopped()
    {
        if (IsPause == false) {
            IsPause = true;
            Time.timeScale = 0;
          
            return;
        }
 
    }
}
