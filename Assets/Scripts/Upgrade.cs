using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public Text upgradeText;

    [SerializeField] // Inspector X
    public static int kill;
    public static int level = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 1)
        {
            int remain = 15 - kill;
            upgradeText.text = "레벨 2 까지 :" + remain;
            if (remain <= 0) 
            { 
                level = 2; 
                kill = 0;
            }
        }
        else if (level == 2)
        {
            int remain = 40 - kill;
            upgradeText.text = "레벨 3 까지 :" + remain;
            if (remain <= 0)
            {
                level = 3;
                kill = 0;
            }
        }
        else if (level == 3)
        {
            int remain = 80 - kill;
            upgradeText.text = "레벨 4 까지 :" + remain;
            if (remain <= 0)
            {
                level = 4;
                kill = 0;
            }
        }
        else { upgradeText.text = "최고 레벨"; }
    }
}
