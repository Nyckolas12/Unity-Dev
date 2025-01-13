using UnityEngine;

public class Roket : MonoBehaviour
{

    public float force = 10;
    void Start()
    {
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * force, ForceMode.VelocityChange);
    }

    void Update()
    {
        
    }
}
