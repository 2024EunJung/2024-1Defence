using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Top : MonoBehaviour
{
    public GameObject prefabtop1;
    public Sprite c_1;
    public Sprite c_2;
    public Sprite c_3;

    Image thisImg;
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
            if (Upgrade.level == 2)
                {
                    spriteRenderer.sprite = c_1;
                }
            else if (Upgrade.level == 3)
                {
                    spriteRenderer.sprite = c_2;
                }
            else if (Upgrade.level == 4)
                {
                    spriteRenderer.sprite = c_3;
                }
            yield return new WaitForSeconds(0.1f);
        }
    }
}