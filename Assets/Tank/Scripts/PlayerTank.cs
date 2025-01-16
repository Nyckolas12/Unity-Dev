using TMPro;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PLayerTank : MonoBehaviour, IDamagable
{
    [SerializeField] float maxTorque = 90;
    [SerializeField] float maxForce = 10;
    [SerializeField] GameObject rocket;
    [SerializeField] Transform barrel;
    public int ammo = 10;
    [SerializeField] TMP_Text ammoText;

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

        

        if(Input.GetKeyDown(KeyCode.Space) && ammo > 0)
        {
            ammo--;
            Instantiate(rocket, barrel.position + Vector3.up, barrel.rotation);
        }
        ammoText.text = "Ammo: " + ammo.ToString();
    }

    private void FixedUpdate()
    {
        rb.AddRelativeForce(Vector3.forward * force);
        rb.AddRelativeTorque(Vector2.up * torque);
    }

    public void ApplyDamage(float damage)
    {
        
    }
}
