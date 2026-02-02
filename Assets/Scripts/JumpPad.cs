using Unity.VisualScripting;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] private float _bounceForce = 15f;
    private SpriteRenderer _renderer;
    private Color _orignialColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _orignialColor = _renderer.color;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            if (collision.rigidbody != null)
            {
                collision.rigidbody.AddForce(Vector2.up * _bounceForce, ForceMode2D.Impulse);
            }
            _renderer.color = Color.green;
            Invoke("ResetColor", 0.5f);
        }
    }
    private void ResetColor()
    {
        _renderer.color = _orignialColor;
    }
}
