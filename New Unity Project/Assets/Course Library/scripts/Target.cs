using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minspeed = 12;
    private float maxspeed = 16;
    private float maxtorque = 10;
    private float ySpawnPos = -6;
    private float xRange = 4;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
        Vector3 RandomForce() { return  Vector3.up * Random.Range(minspeed, maxspeed);}
        float RandomTorque () { return Random.Range(-maxtorque, maxtorque);}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
    }
}
