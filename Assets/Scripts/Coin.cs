using UnityEngine;

public class Collectible : MonoBehaviour
{
    private Collider2D _collider;
    private SpriteRenderer _visuals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
        _visuals = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Rigidbody2D>() != null)
        {
            HideCoin();
            Invoke("ResetCoin", 3f);
        }
    }
    private void HideCoin()
    {
        _visuals.enabled = false;
        _collider.enabled = false;
    }
    private void ResetCoin()
    {
        _visuals.enabled = true;
        _collider.enabled = true;
    }
}
