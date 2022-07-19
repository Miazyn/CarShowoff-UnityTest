using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAndRotate : MonoBehaviour
{
    //Object Camera will look at
    public Transform target;
    
    public int rotationSpeed = 1;

    private void FixedUpdate()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.right* rotationSpeed*Time.deltaTime);
    }
}
