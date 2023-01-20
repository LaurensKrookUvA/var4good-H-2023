using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using TMPro;

public class RotaryKnobController : MonoBehaviour
{
    [SerializeField] private ActionBasedController controller;
    [SerializeField] private InputActionAsset inputActionAsset;
    [SerializeField] private TextMeshProUGUI display;
    private bool _isPressed = false;
    private bool _set = false;
    private Quaternion _startRot, _objectRot, _controllerRot;
    private int _temp = 38;
    private float _totalRotation = 0;
    private Renderer _renderer;
    private Color _color;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponentInChildren<MeshRenderer>();
        _renderer.material.color = Color.blue;
        display.text = _temp.ToString() + " °C";
        display.color = Color.blue;
        _startRot = transform.rotation;
        transform.Rotate(0, 0, 180);
        var select = inputActionAsset.FindActionMap("XRI RightHand Interaction").FindAction("Select");
        select.Enable();
        select.performed += OnSelect;
        select.canceled += OnSelectCancel;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isPressed && Vector3.Distance(controller.transform.position, transform.position) < 0.2f)
        {
            if (!_set)
            {
                _objectRot = transform.rotation;
                _controllerRot = controller.transform.rotation;
                _set = true;
            }
            Quaternion difference = controller.transform.rotation * Quaternion.Inverse(_controllerRot);
            transform.rotation = difference * _objectRot;
            transform.eulerAngles = new Vector3(_objectRot.eulerAngles.x, _objectRot.eulerAngles.y, transform.eulerAngles.z);

            _totalRotation = transform.rotation.eulerAngles.z - _startRot.eulerAngles.z - 180.0f;
            _temp = 38 + (int)(_totalRotation / (180 / 12));
            _color = Color.Lerp(Color.blue, Color.red, _totalRotation / 180);
            _renderer.material.color = _color;
            display.color = _color;
            display.text = _temp.ToString() + " °C";
        }
        else
        {
            _set = false;
        }
    }

    void OnSelect(InputAction.CallbackContext context)
    {
        _isPressed = true;
    }

    void OnSelectCancel(InputAction.CallbackContext context)
    {
        _isPressed = false;
    }
}
