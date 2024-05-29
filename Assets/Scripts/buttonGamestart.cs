using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonGamestart : MonoBehaviour
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
    public void buttonclik()
    {
        SceneManager.LoadScene("SampleScene");
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
