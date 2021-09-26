using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody rd = bullet.GetComponent<Rigidbody>();
            rd.velocity = Vector3.forward * 50;
        }
    }
}
