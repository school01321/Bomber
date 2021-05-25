using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public Transform target;
    private Rigidbody rig;
    public float speed = 25f;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(target.position, transform.position) < 10f)
        {
            Vector3 trans = target.position - transform.position;
            rig.AddForce(trans * speed * Time.deltaTime);
        }
    }
}
