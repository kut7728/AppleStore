using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSaesaemi : MonoBehaviour
{
    public GameObject targetPosition; // 목표 위치
    public GameObject objectToMove1; // 이동할 객체
    // public GameObject objectToMove2; // 이동할 객체

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void MoveObject()
    {
        // Debug.Log("does it work at all?");
        // Debug.Log(objectToMove.transform.position);
        // Debug.Log(targetPosition.transform.position);


        if (objectToMove1 != null && targetPosition != null)
        {
            // objectToMove.transform.position = targetPosition.position;
            // objectToMove.transform.position = target;
            // objectToMove1.transform.position.z += 3f;
            // objectToMove2.transform.position = targetPosition.transform.position;
        }
        else
        {
            Debug.LogError("Object or target position is not assigned.");
        }
    }
}
