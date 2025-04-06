using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public Rigidbody2D cat; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    [SerializeField] private Transform mouse;
    // Update is called once per frame
    void Update()
    {
        Vector2 direction = mouse.position - transform.position;
        cat.AddForce(direction.normalized);
    }
}
