using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class WristUI : MonoBehaviour
{
    public InputActionAsset inputActions;
    public TextMeshProUGUI debug;
    private Canvas _wristUICanvas;
    private InputAction _menu;
    private InputAction action;
    
    private void Start()
    {
        _wristUICanvas = GetComponent<Canvas>();
        action = inputActions.FindActionMap("XRI LeftHand").FindAction("Primary");
        action.Enable();
        action.started += Primary;
    }

    public void Primary(InputAction.CallbackContext context){
        _wristUICanvas.enabled = !_wristUICanvas.enabled;
        Debug.Log("Primary Pressed"+ _wristUICanvas.enabled);
    }

    // Gets destroyed in new scene, may want to prevent this.
    private void OnDestroy()
    {
        action.performed -= Primary;
    }
}