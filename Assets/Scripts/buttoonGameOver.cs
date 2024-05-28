using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoonGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        pause.IsPause = false;
    }

    // Update is called once per frame
    void Update()
    {
     
      
    }
    public void buttonClik()
    {
        SceneManager.LoadScene("gamestart");
    }
    public void Stopped()
    {
        if (pause.IsPause == false)
        {
            Time.timeScale = 0;
            pause.IsPause = true;
            return;
        }

    }
}
