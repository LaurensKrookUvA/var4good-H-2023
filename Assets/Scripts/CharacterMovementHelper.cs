using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;
using UnityEngine.XR.Interaction.Toolkit;

public class CharacterMovementHelper : MonoBehaviour
{
    private XROrigin xROrigin;
    private CharacterController characterController;
    private CharacterControllerDriver driver;

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();
    }

    protected virtual void UpdateCharacterController()
    {
    if (xROrigin == null || characterController == null)
        return;

    var height = Mathf.Clamp(xROrigin.CameraInOriginSpaceHeight, driver.minHeight, driver.maxHeight);

    Vector3 center = xROrigin.CameraInOriginSpacePos;
    center.y = height / 2f + characterController.skinWidth;

    characterController.height = height;
    characterController.center = center;
    }
}
