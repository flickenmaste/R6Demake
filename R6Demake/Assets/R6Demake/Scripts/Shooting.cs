using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public Vector3 rayDirection;
    public Vector3 shootDirection;
    public GameObject gun;
    public Rigidbody bullet;
    
    // Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
        ChangeAim();
        Debug.DrawRay(this.gameObject.transform.position, rayDirection, Color.red);
        Shoot();
	}

    void ChangeAim()
    {
        if (!Input.GetKey(KeyCode.Space))
        {
            if (Input.GetKey(KeyCode.W))
            {
                rayDirection = new Vector3(0, 0, 1);
                gun.gameObject.transform.position = (this.gameObject.transform.position + rayDirection);
                shootDirection = new Vector3(0, 0, 1);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rayDirection = new Vector3(0, 0, -1);
                gun.gameObject.transform.position = (this.gameObject.transform.position + rayDirection);
                shootDirection = new Vector3(0, 0, -1);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rayDirection = new Vector3(-1, 0, 0);
                gun.gameObject.transform.position = (this.gameObject.transform.position + rayDirection);
                shootDirection = new Vector3(-1, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rayDirection = new Vector3(1, 0, 0);
                gun.gameObject.transform.position = (this.gameObject.transform.position + rayDirection);
                shootDirection = new Vector3(1, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            gun.gameObject.transform.position = (this.gameObject.transform.position + rayDirection);
        }
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody clone;
            clone = Instantiate(bullet, gun.gameObject.transform.position, Quaternion.identity) as Rigidbody;
            clone.velocity += shootDirection * 10;
        }
    }
}
