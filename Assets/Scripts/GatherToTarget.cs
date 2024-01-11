using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherToTarget : MonoBehaviour
{
    public GameObject targetPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(gameObject.transform.position, targetPosition.transform.position, 0.003f);
    }
}
