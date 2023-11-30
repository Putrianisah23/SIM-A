using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour
{
    public GameObject ktp, pasfoto, serti, susehat;

    public GameObject item_ktp, item_pasfoto, item_serti, item_susehat;

    public GameObject popup_ktp, popup_pasfoto, popup_serti, popup_susehat, list, info;

    public GameObject cek_ktp, cek_pasfoto, cek_serti, cek_susehat , finish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ktp.activeSelf == false) 
        {
            popup_pasfoto.SetActive(false);
            popup_serti.SetActive(false);
            popup_susehat.SetActive(false);

            cek_ktp.SetActive(true);
            popup_ktp.SetActive(true);
            item_ktp.SetActive(false);

        }
        
        if(pasfoto.activeSelf == false) 
        {
            popup_ktp.SetActive(false);
           
            popup_serti.SetActive(false);
            popup_susehat.SetActive(false);

            cek_pasfoto.SetActive(true);
            popup_pasfoto.SetActive(true);
            item_pasfoto.SetActive(false);
           
        }
        
        if(serti.activeSelf == false) 
        {
            popup_ktp.SetActive(false);
            popup_pasfoto.SetActive(false);
          
            popup_susehat.SetActive(false);

            cek_serti.SetActive(true);
            popup_serti.SetActive(true);
            item_serti.SetActive(false);
           
        }

        if(susehat.activeSelf == false) 
        {
            popup_ktp.SetActive(false);
            popup_pasfoto.SetActive(false);
            popup_serti.SetActive(false);
            

            cek_susehat.SetActive(true);
            popup_susehat.SetActive(true);
            item_susehat.SetActive(false);
           
        }

        if (ktp.activeSelf == false && pasfoto.activeSelf == false && serti.activeSelf == false && susehat.activeSelf == false)
        {
            list.SetActive(false);
            popup_ktp.SetActive(false);
            popup_pasfoto.SetActive(false);
            popup_serti.SetActive(false);
            popup_susehat.SetActive(false);
            
            cek_ktp.SetActive(false);
            cek_pasfoto.SetActive(false);
            cek_serti.SetActive(false);
            cek_susehat.SetActive(false);

            info.SetActive(false);
            finish.SetActive(true);
        }
    }

    void PopUpHide()
    {
        popup_ktp.SetActive(false);
        popup_pasfoto.SetActive(false);
        popup_serti.SetActive(false);
        popup_susehat.SetActive(false);
    }
}
