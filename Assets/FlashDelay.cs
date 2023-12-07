using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashDelay : MonoBehaviour
{

  
    public GameObject flash;
 
    void Update()
    {
        StartCoroutine(Hilang());
    }

     IEnumerator Hilang()
    {
        yield return new WaitForSeconds(0.2f);
        flash.SetActive(false);
    }

}
