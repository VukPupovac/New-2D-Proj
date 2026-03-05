using Unity.VisualScripting;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    private InputSystem_Actions _input;
    private Vector2 _moveInput;
    [SerializeField] private int _moveSpeed = 5;
    [SerializeField] private int _turnSpeed = 5;

    void Start()
    {
        _input = new InputSystem_Actions();
    }

    // Update is called once per frame
    void Update()
    {
        _moveInput = _input.Player.Move.ReadValue<Vector2>();

        if (_input.Player.Move.IsPressed())
        {
            transform.Translate(_moveInput * _moveSpeed * Time.deltaTime, Space.World);
            Debug.Log("Pressed");
        }

        if (_input.Player.SpinLeft.IsPressed())
        {
            transform.Rotate(0,0,_turnSpeed * Time.deltaTime);
        }
        if (_input.Player.SpinRight.IsPressed())
        {
            transform.Rotate(0,0,-_turnSpeed * Time.deltaTime);
        }
    }
}
