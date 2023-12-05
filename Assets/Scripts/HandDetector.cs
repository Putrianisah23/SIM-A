using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;


public class HandDetector : MonoBehaviour
{
    private InputData _inputData;
    private float righttriggerValue;
    private Quaternion controllerPosition;
    public Toggle togglehand;
    public GameObject tutorhandPanel;
     public GameObject skipButton;
     public GameObject nextButton;

    // Start is called before the first frame update
    void Start()
    {
        _inputData = GetComponent<InputData>();
        Debug.Log("Started inputData: " + _inputData);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("handTest", 3f);
    }
    private void handTest()
    {
        // tutor tangan
        if (_inputData._rightController.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 controllerPosition))
        {
            if (controllerPosition.y >= 0.5f && controllerPosition.x > 0f)
            {
                Debug.Log(" Controller Berhasil : " + controllerPosition);
                handToggle();
                CancelInvoke();

            }
        }
    }
    private void handToggle()
    {
        if (togglehand.isOn = true)
        {
            tutorhandPanel.SetActive(true);
            skipButton.SetActive(false);
            nextButton.SetActive(true);

        }
    }
}
