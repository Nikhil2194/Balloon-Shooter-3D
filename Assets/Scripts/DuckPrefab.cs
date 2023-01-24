using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckPrefab : MonoBehaviour
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
        RotateDuck();
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
            shooting.ScoreDown();
        }

    }


    public void RotateDuck()
    {
        transform.localEulerAngles = new Vector3( 0, 0, Mathf.PingPong(Time.time * 22f, 30) - 30);
    }
}
