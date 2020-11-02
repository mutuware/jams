using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var renderer = GetComponent<Renderer>();
        renderer.material.color = new Color(Random.Range(0.2f, 0.8f), Random.Range(0.05f, 0.15f), Random.Range(0.05f, 0.15f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void OnCollisionEnter(Collision collision)
    //{
    //    //Debug.Log("collision " + collision);
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        Destroy(this.gameObject, 0.75f);
    //    }
    //}
}
