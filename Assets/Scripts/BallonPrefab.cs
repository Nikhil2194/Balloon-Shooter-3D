using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonPrefab : MonoBehaviour
{
    //public float spped = 3f;
    //public float smoothTIme = 0.5f;
    //public Vector3 targetPos = new Vector3(0, 5, 0);
    //Vector3 currentVelocity;

     Rigidbody rb;
    public float forceStrength = 20;
    public ParticleSystem balloonExplode;
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
        if(other.CompareTag("Bullet"))
        {
            balloonExplode.Play();
            Destroy(this.gameObject, 0.1f);
             shooting.ScoreUp();
        }

    }






}
