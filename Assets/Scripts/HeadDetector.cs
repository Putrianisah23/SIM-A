using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;


public class HeadDetector : MonoBehaviour
{
    private InputData _inputData;
    private Quaternion headmountedValue;
    public Toggle toggleHead;
    public GameObject tutorheadPanel;
     public GameObject skipButton;
     public GameObject nextButton;
    // public GameObject tutorhandPanel;

    // Start is called before the first frame update
    void Start()
    {
        _inputData = GetComponent<InputData>();
        Debug.Log("Started inputData: " + _inputData);
    }

    // Update is called once per frame
    void Update()
    {
        headTest();
    }
    private void headTest()
    { 
        // tutor kepala
        if (_inputData._HMD.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion headMountedValue))
        {
            Vector3 eulerRotation = headMountedValue.eulerAngles;

            lookArround();

            // Debug.Log("headMountedValue: " + headMountedValue);
        }

        // liat arah
        void lookArround()
        {
            float yRotation = headMountedValue.eulerAngles.y;
            if (yRotation >= 50.0f && yRotation <= 90.0f || yRotation >= 270.0f && yRotation <= 310.0f)
            {
                Debug.Log("head berhasil : " + yRotation);
                headToggle();

            }
        }
    }
    private void headToggle()
    {
        if (toggleHead.isOn = true)
        {
            tutorheadPanel.SetActive(true);
            skipButton.SetActive(false);
            nextButton.SetActive(true);
            // tutorhandPanel.SetActive(true);

        }
    }
 }
