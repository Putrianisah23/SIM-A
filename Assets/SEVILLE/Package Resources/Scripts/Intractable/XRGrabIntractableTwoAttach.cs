using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Seville
{
    public class XRGrabIntractableTwoAttach : XRGrabInteractable
    {

        public string objName;
        public Transform rightAttachTransform;
        public Transform leftAttachTransform;

        public GameObject barang;



        public override Transform GetAttachTransform(IXRInteractor interactor)
        {
            // Debug.Log("GetAttachTransform");

            Transform i_attachTransform = null;

            if (interactor.transform.CompareTag("Left Hand"))
            {
                // Debug.Log("Left");
                i_attachTransform = leftAttachTransform;
                 StartCoroutine(DisableObject());
            }
            if (interactor.transform.CompareTag("Right Hand"))
            {
                // Debug.Log("Right");
                i_attachTransform = rightAttachTransform;
                StartCoroutine(DisableObject());
            }
            return i_attachTransform != null ? i_attachTransform : base.GetAttachTransform(interactor);
        }

        private IEnumerator DisableObject()
        {
            yield return new WaitForSeconds(5f);
            gameObject.SetActive(false);
        }
}
}