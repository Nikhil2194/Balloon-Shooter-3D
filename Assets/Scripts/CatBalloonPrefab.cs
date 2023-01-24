using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBalloonPrefab : MonoBehaviour
{
    Rigidbody rb;
    public float forceStrength = 20;
    private Shooting shooting;


 
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        shooting = GameObject.FindObjectOfType<Shooting>();
    }
    void Update()
    {
        // transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref currentVelocity, smoothTIme);

        Destroy(this.gameObject, 24f);
    }
    private void FixedUpdate()
    {
        rb.AddForce(Vector3.up * forceStrength);
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(this.gameObject, 0.1f);

            shooting.ScoreDown2();
        }

    }




  
}
