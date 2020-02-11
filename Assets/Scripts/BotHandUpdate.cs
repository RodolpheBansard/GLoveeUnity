using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotHandUpdate : MonoBehaviour
{
    
    float[] rock = new float[45] { 49.6f, -116.9f, -81.4f, -43, 15.1f, -51.9f, 27.6f, 43.5f, -40.4f, 8.9f, -0.1f, -93.1f, 0.1f, 1.4f, -87.5f, 1, 1.2f, -81.8f, 2, 2.9f, -94.7f, -2.2f, -0.6f, -84.6f, 0.4f, -0.8f, -81.6f, 1, 11.5f, -93.4f, 0.7f, 1.6f, -98.7f, 2.4f, -8.5f, -56.5f, 0.1f, 16, -92.6f, 1.3f, 1.1f, -93.2f, 0.4f, -3.9f, -76.7f };
    float[] paper = new float[45] { 65.6f, -99.9f, -62.0f, -1, -9.9f, -14.9f, 2.5f, 0, 12.4f, 15, -3.2f, -26.4f, 1.4f, 0.2f, -12, 1.3f, -0.8f, 9.5f, 4.5f, 5.8f, -22.7f, -2.2f, -0.7f, -12.3f, -0.4f, 4.44f, 15.3f, -8.1f, 15.4f, -23.1f, 0.7f, 1.6f, -13.3f, 0.3f, -3, 12.9f, -11.3f, 24, -19.5f, 1.3f, 1.1f, -11.2f, 0.4f, -3.9f, -1 };
    float[] cisor = new float[45] { 42.8f, -116.8f, -111.5f, -23.9f, -26.4f, -28.4f, 32.6f, 1.8f, -54.4f, 15, -3.2f, -26.4f, 1.4f, 0.2f, -12, 1.3f, -0.8f, 9.5f, 4.5f, 5.8f, -22.7f, -2.2f, -0.7f, -12.3f, -0.4f, 4.44f, 15.3f, 1, 11.5f, -93.4f, 0.7f, 1.6f, -98.7f, 2.4f, -8.5f, -56.5f, 0.1f, 16, -92.6f, 1.3f, 1.1f, -93.2f, 0.4f, -3.9f, -76.7f };

    private enum PhalangeObject
    {
        thumb1,
        thumb2,
        thumb3,
        index1,
        index2,
        index3,
        middle1,
        middle2,
        middle3,
        ring1,
        ring2,
        ring3,
        pinky1,
        pinky2,
        pinky3,
    };

    [SerializeField] PhalangeObject phalange = PhalangeObject.index1;
    private float[] fingersRotations;

    private void Update() {
        UpdateBot();
    }

    private void UpdateBot()
    {
        int signe = FindObjectOfType<GameSession>().GetSigne();
        if (signe == 0)
        {
            fingersRotations = rock;
        }
        else if (signe == 1)
        {
            fingersRotations = paper;
        }
        else if (signe == 2)
        {
            fingersRotations = cisor;
        }
        readRotation();
    }
    

    private void readRotation()
    {     
        if (phalange == PhalangeObject.thumb1)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[0], fingersRotations[1], fingersRotations[2]);
        }
        else if (phalange == PhalangeObject.thumb2)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[3], fingersRotations[4], fingersRotations[5]);
        }
        else if (phalange == PhalangeObject.thumb3)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[6], fingersRotations[7], fingersRotations[8]);
        }
        else if (phalange == PhalangeObject.index1)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[9], fingersRotations[10], fingersRotations[11]);
        }
        else if (phalange == PhalangeObject.index2)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[12], fingersRotations[13], fingersRotations[14]);
        }
        else if (phalange == PhalangeObject.index3)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[15], fingersRotations[16], fingersRotations[17]);
        }
        else if (phalange == PhalangeObject.middle1)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[18], fingersRotations[19], fingersRotations[20]);
        }
        else if (phalange == PhalangeObject.middle2)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[21], fingersRotations[22], fingersRotations[23]);
        }
        else if (phalange == PhalangeObject.middle3)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[24], fingersRotations[25], fingersRotations[26]);
        }
        else if (phalange == PhalangeObject.ring1)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[27], fingersRotations[28], fingersRotations[29]);
        }
        else if (phalange == PhalangeObject.ring2)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[30], fingersRotations[31], fingersRotations[32]);
        }
        else if (phalange == PhalangeObject.ring3)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[33], fingersRotations[34], fingersRotations[35]);
        }
        else if (phalange == PhalangeObject.pinky1)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[36], fingersRotations[37], fingersRotations[38]);
        }
        else if (phalange == PhalangeObject.pinky2)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[39], fingersRotations[40], fingersRotations[41]);
        }
        else if (phalange == PhalangeObject.pinky3)
        {
            transform.localEulerAngles = new Vector3(fingersRotations[42], fingersRotations[43], fingersRotations[44]);
        }


        

    }
}
