using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using TMPro;
using UnityEngine.UI;

public class TriggerInputDetector : MonoBehaviour
{
    private InputData _inputData;
    private float lefttriggerValue;
    private float righttriggerValue;

    private Quaternion controllerPosition;
    private Quaternion headmountedValue;

    public Toggle toggleHead;
    public Toggle togglehand;
    public Toggle togglebutton;

    public GameObject tutorheadPanel;
    public GameObject tutorhandPanel;
    public GameObject tutorbuttonPanel;

    public GameObject tutorcompletedPanel;
    
    public GameObject skipButton;
    
    private int buttonClick = 0;

    private void Start()
    {
        _inputData = GetComponent<InputData>();
        Debug.Log("Started inputData: " + _inputData);
    }
    // Update is called once per frame
    void Update()
    {
        headTest();
        handTest();
        buttonTest();
    
    //     // trigger kanan
    //     // if (_inputData._rightController.TryGetFeatureValue(CommonUsages.trigger, out float righttriggerValue))
    //     // {
    //     //     Debug.Log("righttriggerValue: " + righttriggerValue);
    //     // }
    }

    private void buttonTest()
    {

        // trigger kiri
        if (_inputData._leftController.TryGetFeatureValue(CommonUsages.trigger, out  lefttriggerValue))
        {

            if (lefttriggerValue >= 1)
            {
                Debug.Log("yey berhasil");
                buttonToggle();
            }
            Debug.Log("lefttriggerValue: " + lefttriggerValue);
        }
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

    private void handTest()
    {
        // tutor tangan
        if (_inputData._rightController.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 controllerPosition))
        {
            if (controllerPosition.y >= 0.3f && controllerPosition.x >0f)
            { 
                Debug.Log(" Controller Berhasil : " + controllerPosition);
                handToggle();
        
            }
        }
    }

    private void headToggle()
    {
        if (toggleHead.isOn = true)
        {
            tutorheadPanel.SetActive(false);
            tutorhandPanel.SetActive(true);
        }
           
    }
    private void handToggle()
    {
        if (togglehand.isOn = true)
        {
            tutorhandPanel.SetActive(false);
            tutorbuttonPanel.SetActive(true);
            
        }
    }
    private void buttonToggle()
    {
        buttonClick++;
        if (buttonClick >= 1) 
        {
            tutorbuttonPanel.SetActive(false);
            skipButton.SetActive(false);
            tutorcompletedPanel.SetActive(true);
        }
    }
}