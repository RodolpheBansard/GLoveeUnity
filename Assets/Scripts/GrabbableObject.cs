using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    SerialManager serialManager;

    private int indexServo;
    
    void Start()
    {
        serialManager = FindObjectOfType<SerialManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        indexServo = GetIndexServo(other.tag);
        serialManager.SetServoEnable(indexServo, 1);
        print(other.tag);
    }

    /*private void OnTriggerExit(Collider other)
    {
        indexServo = GetIndexServo(other.tag);
        serialManager.SetServoEnable(indexServo, 0);
        print(other.tag);
    }*/


    private int GetIndexServo(string tag)
    {
        if(tag == "Thumb")
        {
            return 0;
        }
        else if (tag == "Index")
        {
            return 1;
        }
        else if (tag == "Middle")
        {
            return 2;
        }
        else if (tag == "Ring")
        {
            return 3;
        }
        else
        {
            return 4;
        }
    }
}
