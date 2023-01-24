using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 10f;
 // private Shooting shooting;
   // public ParticleSystem ballonExplosion;
  

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void Start()
    {
    //  shooting = GameObject.FindObjectOfType<Shooting>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Balloon"))
        //{
        //    // Destroy(collision.gameObject);
        //    //   ballonExplosion.Play();
        //    shooting.ScoreUp();
        //}
    }


}
