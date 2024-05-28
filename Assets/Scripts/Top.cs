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
                Vector2 mousePos = Input.mousePosition; //마우스의 스크린 좌표를 입력받는다.
                Vector2 target = Camera.main.ScreenToWorldPoint(mousePos); //입력 받은 마우스의 좌표값을 월드좌표로 변환
                Instantiate(prefabtop1, target, Quaternion.identity); //변환한 위치에 원하는 오브젝트를 생성
            }

            yield return new WaitForSeconds(0.1f);
        }
    }
}