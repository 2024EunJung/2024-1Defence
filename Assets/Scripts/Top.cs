using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Top : MonoBehaviour
{
    public GameObject prefabtop1;
    public Sprite c_2;
    public Sprite c_3;

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
            if (CreaateTop.top == 1 && Input.GetMouseButtonDown(0))
            {
                Vector2 mousePos = Input.mousePosition; //���콺�� ��ũ�� ��ǥ�� �Է¹޴´�.
                Vector2 target = Camera.main.ScreenToWorldPoint(mousePos); //�Է� ���� ���콺�� ��ǥ���� ������ǥ�� ��ȯ
                Instantiate(prefabtop1, target, Quaternion.identity); //��ȯ�� ��ġ�� ���ϴ� ������Ʈ�� ����
            }

            yield return new WaitForSeconds(0.1f);
        }
    }
}