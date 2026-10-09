using UnityEngine;

public class Jump : MonoBehaviour
{
    int jumpForce = 10;
    [SerializeField] private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void jump()
    {
        if(Physics2D.Raycast(transform.position,Vector3.down, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
        }
    }
}
