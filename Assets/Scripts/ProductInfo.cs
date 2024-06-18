using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProductInfo : MonoBehaviour
{
    public TMP_Text infoText; // UI 텍스트 컴포넌트

    void Start ()
    {

    }

    void Update()
    {
        // 마우스 왼쪽 버튼이 클릭되었는지 확인
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 포인터가 가리키는 객체 가져오기
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // 객체에 충돌이 감지되었는지 확인
            if (Physics.Raycast(ray, out hit))
            {
                // 충돌한 객체가 GameObject이고, 그 객체에 존재하는 Collider가 있다면
                if (hit.collider != null)
                {
                    // 클릭된 객체의 정보를 표시할 UI 텍스트 업데이트
                    if (hit.collider.gameObject.name == "Thank you for purchasing!") {
                        infoText.text = hit.collider.gameObject.name;
                    } else {
                        infoText.text = "This is " + hit.collider.gameObject.name;
                    }
                    

                    // UI 텍스트 활성화
                    infoText.gameObject.SetActive(true);
                }
            }
        }
    }
}