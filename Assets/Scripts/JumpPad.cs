using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{

    public GameObject player;
    Vector3 direction;
    public float jumpForce = 20f;

    // Update is called once per frame
    void Update()
    {
        direction = transform.TransformDirection(Vector3.up*jumpForce);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //applies only to objects tagged with “Player”
        {
        player = collision.gameObject;
        //apply force to the Player's rigidbody to let him "jump"
        player.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
        }
    }
}
