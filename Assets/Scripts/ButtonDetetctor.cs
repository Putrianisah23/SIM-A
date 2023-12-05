using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class ButtonDetetctor : MonoBehaviour
{
    private InputData _inputData;
    private float lefttriggerValue;
    public Toggle togglebutton;
    private int buttonClick = 0;

    public GameObject tutorbuttonPanel;
    public GameObject tutorcompletedPanel;

    public GameObject skipButton;
    // Start is called before the first frame update
    void Start()
    {
        _inputData = GetComponent<InputData>();
        Debug.Log("Started inputData: " + _inputData);
    }

    // Update is called once per frame
    void Update()
    {
        buttonTest();
    }
    private void buttonTest()
    {

        // trigger kiri
        if (_inputData._leftController.TryGetFeatureValue(CommonUsages.trigger, out lefttriggerValue))
        {

            if (lefttriggerValue >= 1)
            {
                Debug.Log("yey berhasil");
                buttonToggle();
            }
            Debug.Log("lefttriggerValue: " + lefttriggerValue);
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
