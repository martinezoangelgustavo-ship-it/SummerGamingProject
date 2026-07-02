using UnityEngine;

public class test : MonoBehaviour
{
    // Primitive data types :)
    private int _varInt = 5;
    private float _varFloat = 1.0f;
    private string _varString = "5aa";
    private bool _varBool = false;

    // Complex data types :(
    private Collider _playerCollider;
    public Rigidbody rb;

    

    // Start is called once before the first execution of Update after MonoBehaviour is created
    void Start()
    {
        Debug.Log("Holi :)");
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector3(_varFloat, 0f, 0f);
    }

    private void FixedUpdate()
    {
        
    }
}
