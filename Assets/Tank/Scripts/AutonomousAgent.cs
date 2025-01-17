using System.Net.Sockets;
using System.Threading;
using UnityEngine;

public class AutonomousAgent : AIAgent
{
    [SerializeField] GameObject rocket;
    [SerializeField] Transform barrel;
    public Perception perception;

    private void Update()
    {
       

        Debug.DrawRay(transform.position, transform.forward * perception.maxDistance, Color.yellow);
        var gameObjects = perception.GetGameObjects();
        foreach (var go in gameObjects)
        {
            Debug.DrawLine(transform.position, go.transform.position, Color.magenta);
            Instantiate(rocket, barrel.position + Vector3.up, barrel.rotation);

        }
    }
}
