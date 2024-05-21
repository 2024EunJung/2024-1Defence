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
            upgradeText.text = "���׷��̵���� :" + remain;
            if (remain <= 0) 
            { 
                level = 2; 
                kill = 0;
            }
        }
        else if (level == 2)
        {
            int remain = 25 - kill;
            upgradeText.text = "���׷��̵���� :" + remain;
            if (remain <= 0)
            {
                level = 3;
                kill = 0;
            }
        }
        else if (level == 3)
        {
            int remain = 35 - kill;
            upgradeText.text = "���׷��̵���� :" + remain;
            if (remain <= 0)
            {
                level = 4;
                kill = 0;
            }
        }
        else { upgradeText.text = "�ְ� ����"; }
    }
}
