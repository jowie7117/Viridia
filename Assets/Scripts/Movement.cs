using UnityEngine;

public class Movement : MonoBehaviour
{
    private float velocityX;
    private float velocityY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2d>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
