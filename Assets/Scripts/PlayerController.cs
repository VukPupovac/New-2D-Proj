using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private PlayerInputActions _input;
    private Vector2 _moveInput;
    [SerializeField] private float _moveSpeed = 5f;
    private Rigidbody2D _rb;
    private void Awake()
    {
        _input = new PlayerInputActions();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnEnable()
    {
        _input.Enable();
    }
    private void OnDisable()
    {
        _input.Disable();
    }
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        _moveInput = _input.Player.Move.ReadValue<Vector2>();

        _rb.linearVelocity = _moveInput * _moveSpeed;

    }
}
