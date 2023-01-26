using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class WristUI : MonoBehaviour
{
    public InputActionAsset inputActions;
    public TextMeshProUGUI debug;
    private GameObject wristUICanvas;
    private GameObject energyCanvas;
    private InputAction action;
    private InputAction energy;
    private bool wristActive = true;
    private bool energyActive = false;
    
    private void Start()
    {
        wristUICanvas = GameObject.Find("wristUICanvas");
        energyCanvas = GameObject.Find("energyCanvas");
        energyCanvas.SetActive(false);
        action = inputActions.FindActionMap("XRI LeftHand").FindAction("Primary");
        energy = inputActions.FindActionMap("XRI LeftHand").FindAction("Secondary");
        action.Enable();
        energy.Enable();
        action.started += Primary;
        energy.started += Secondary;
    }

    public void Primary(InputAction.CallbackContext context){
        if (!context.started) {
            return;
        }
        if (energyActive) {
            energyActive = !energyActive;
            energyCanvas.SetActive(energyActive);
        }
        wristUICanvas.SetActive(!wristActive);
        wristActive = !wristActive;
    }

    public void Secondary(InputAction.CallbackContext context) {
        if (!context.started) {
            return;
        }
        if (wristActive) {  
            wristActive = !wristActive;
            wristUICanvas.SetActive(wristActive);
        }
        energyCanvas.SetActive(!energyActive);
        energyActive = !energyActive;
    }
}