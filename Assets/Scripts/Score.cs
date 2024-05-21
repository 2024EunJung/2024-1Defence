using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private float time;
    public int Int_time;
    public int Bestscore;
    public Text BestText;


    void Start()
    {
       if(PlayerPrefs.HasKey("Best"))
        {
            Bestscore = PlayerPrefs.GetInt("Best");
        }
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Int_time = (int)time;

        if (Int_time > Bestscore)
        {
            Bestscore = Int_time;
            PlayerPrefs.SetInt("Best", Bestscore);

        }
        scoreText.text = "Score : " + Int_time.ToString();
        BestText.text = "Best :"  +  Bestscore.ToString();



    }


}

