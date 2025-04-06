using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.AddForce(direction.normalized * force);
    }
}
