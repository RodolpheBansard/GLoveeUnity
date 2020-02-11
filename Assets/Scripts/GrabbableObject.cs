using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    SerialManager serialManager;
    [SerializeField] int servo;
    
    void Start()
    {
        serialManager = FindObjectOfType<SerialManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        serialManager.SetServoEnable(servo, 1);
    }

    private void OnTriggerExit(Collider other)
    {
        serialManager.SetServoEnable(servo, 0);
    }

}
