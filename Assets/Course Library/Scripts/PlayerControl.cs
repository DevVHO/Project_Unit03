using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody bodyCOW;
    public float jump = 10;
    public float GravityModifier = 2f;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        bodyCOW = GetComponent<Rigidbody>();
        Physics.gravity *= GravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space ) && isOnGround)
        {
            bodyCOW.AddForce(Vector3.up * 10f , ForceMode.Impulse);
            isOnGround = false;
        }       
    }

    private void OnTriggerEnter(Collider collider)
    {
        isOnGround = true;
        
    }
}
