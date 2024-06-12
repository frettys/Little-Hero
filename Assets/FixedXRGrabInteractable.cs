using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FixedXRGrabInteractable : XRGrabInteractable
{
    [SerializeField] private Transform leftHandAttachTransform;
    [SerializeField] private Transform rightHandAttachTransform;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = leftHandAttachTransform;
        }

        if (args.interactorObject.transform.CompareTag("RightHand"))
        {  
            attachTransform = rightHandAttachTransform; 
        }

        base.OnSelectEntered(args);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
