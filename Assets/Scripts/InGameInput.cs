using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class InGameInput : MonoBehaviour
{
    [SerializeField] private InputActionAsset _inputActionAsset;

    [Header("Debug")]
    [SerializeField] private TextMeshProUGUI _output;

    public float HORIZONTAL_DEBUG;
    public float VERTICAL_DEBUG;
    public bool SWITCH_DEBUG;


    private InputAction _movement;
    private InputAction _switch;

    private void Start()
    {
        var inputActionMap = _inputActionAsset.FindActionMap("InGame");
        _movement = inputActionMap.FindAction("Movement");
        _switch = inputActionMap.FindAction("SwitchAlive");
    }

    private void Update()
    {
        var m = _movement.ReadValue<Vector2>();
        HORIZONTAL_DEBUG = m.x;
        VERTICAL_DEBUG = m.y;

        SWITCH_DEBUG = _switch.IsPressed();

        _output.SetText($"{HORIZONTAL_DEBUG}\n{VERTICAL_DEBUG}\n{SWITCH_DEBUG}");
    }
}
