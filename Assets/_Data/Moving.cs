using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed = 10f;

    public Rigidbody _rigidbody;
    public float thrust = 20f;
 
    void Start()
    {
        this._rigidbody = transform.parent.GetComponent<Rigidbody>();
    }   


    void FixedUpdate()
    {
        this.MoveByRigibody();
    }

    void Update()
    {
        
    }

    protected virtual void MoveByRigibody()
    {
        float x =-1 * InputManager.instance.vertical;
        float z = InputManager.instance.horizontal;
        Vector3 direction = new Vector3(x, 0, z);
        this._rigidbody.AddForce(direction * this.thrust);
    }
}
