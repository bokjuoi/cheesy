using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public Rigidbody2D cat; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cat.AddForce(Vector2.one);
    }
}
