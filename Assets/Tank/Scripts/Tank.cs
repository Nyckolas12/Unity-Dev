using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] float turnRate = 90;
    [SerializeField] float maxSpeed = 10;
    [SerializeField]  GameObject rocket;
    [SerializeField]  Transform barrel;

    void Start()
    {
        
    }

    
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal");
        float speed = Input.GetAxis("Vertical");

        transform.rotation *= Quaternion.AngleAxis(rotation * turnRate * Time.deltaTime,Vector3.up);
        //transform.position += transform.rotation * Vector3.forward * speed * maxSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * maxSpeed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(rocket, barrel.position + Vector3.up, barrel.rotation);
        }
    }
}
