using UnityEngine;

public class Ball : MonoBehaviour
{
    [Range (1,10)]public float speed = 2;
    public GameObject prefab;
    private void Awake()
    {
        
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 postion = transform.position;
        Vector3 velocity = Vector3.zero;
        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab,transform.position + Vector3.up ,Quaternion.identity);
        }
        /*if (Input.GetButton("Fire1"))
        {

        postion.y += 1 * Time.deltaTime;
        }*/
        transform.position += velocity * speed * Time.deltaTime;
    }
}
