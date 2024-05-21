using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Castle : MonoBehaviour
{
    private float MaxHp;
    private float Damge;
    private Image GuageBar;

    public Sprite change_2;
    public Sprite change_3;
    public Sprite change_4;

    Image thisImg;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        MaxHp = 10;
        Damge = 1;
        GuageBar = GameObject.Find("HpGuage").GetComponent<Image>();
        GuageBar.fillAmount = 1;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GuageBar.fillAmount <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        if(Upgrade.level == 2) 
        {
            spriteRenderer.sprite = change_2;
        }
        else if (Upgrade.level == 3)
        {
            spriteRenderer.sprite = change_3;
        }
        else if (Upgrade.level == 4)
        {
            spriteRenderer.sprite = change_4;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GuageBar.fillAmount -= Damge / MaxHp;
        Destroy(collision.gameObject);
    }
}
