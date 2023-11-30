using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectHandler : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        // Dapatkan referensi ke komponen XRGrabInteractable pada objek ini
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Subscribe event onSelectEnter dan onSelectExited
        grabInteractable.onSelectEntered.AddListener(OnGrabbed);
        grabInteractable.onSelectExited.AddListener(OnReleased);
    }

    private void OnGrabbed(XRBaseInteractor interactor)
    {
        // Logika yang akan dijalankan saat objek dipegang
        Debug.Log("Objek dipegang");

        // Cek apakah objek memiliki tag "benda"
        if (gameObject.CompareTag("benda"))
        {
            // Logika khusus untuk objek dengan tag "benda" yang dipegang
            Debug.Log("Objek dengan tag 'benda' dipegang!");
        }
    }

    private void OnReleased(XRBaseInteractor interactor)
    {
        // Logika yang akan dijalankan saat objek dilepaskan
        Debug.Log("Objek dilepaskan");

        // Cek apakah objek memiliki tag "benda"
        if (gameObject.CompareTag("benda"))
        {
            // Logika khusus untuk objek dengan tag "benda" yang dilepaskan
            Debug.Log("Objek dengan tag 'benda' dilepaskan!");
        }
    }
}