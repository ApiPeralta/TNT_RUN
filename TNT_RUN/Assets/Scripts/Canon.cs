using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject bocaCanion;
    public GameObject bala;
    public GameObject Player_RB;
    private GameObject balaClon;
    public Transform player;
    public float respawningTimer;
    private float seconds = 0;
    
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        Spawn();
    }
    private void Spawn()
    {
        respawningTimer -= Time.deltaTime;
        if (respawningTimer <= 0)
        {
            
            balaClon = Instantiate(bala, bocaCanion.GetComponent<Transform>().position, Quaternion.identity);
            balaClon.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * 20, ForceMode.Impulse);
            respawningTimer = UnityEngine.Random.Range(3, 5);
            Destroy(balaClon, 4);
        }   
    }
}
