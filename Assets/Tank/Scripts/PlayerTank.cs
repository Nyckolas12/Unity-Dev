using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PLayerTank : MonoBehaviour
{
    [SerializeField] float maxTorque = 90;
    [SerializeField] float maxForce = 10;
    [SerializeField] GameObject rocket;
    [SerializeField] Transform barrel;

    float torque;
    float force;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        torque = Input.GetAxis("Horizontal") * maxForce;
        force = Input.GetAxis("Vertical") * maxForce;

        

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(rocket, barrel.position + Vector3.up, barrel.rotation);
        }
    }

    private void FixedUpdate()
    {
        rb.AddRelativeForce(Vector3.forward * force);
        rb.AddRelativeTorque(Vector2.up * torque);
    }
}
