using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D r2d;
    public float speed;
    public bool blockDown, lookLeft;
    public Transform body;
    public Animator animator;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if (blockDown) {
            x = x * speed;
            r2d.velocity = new Vector2(x,r2d.velocity.y);
            if (lookLeft) {
                if (x > 0) {
                    body.localRotation = new Quaternion(body.localRotation.x,
                    0,
                    body.localRotation.z,body.localRotation.w);
                    lookLeft = false;
                }
            } else {
                if (x < 0) {
                    body.localRotation = new Quaternion(body.localRotation.x,
                    180,
                    body.localRotation.z,body.localRotation.w);
                    lookLeft = true;
                }
            }
            animator.SetBool("run",x !=0);
        } else {

        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<BlockScript>() != null) {
            blockDown = true;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<BlockScript>() != null) {
            blockDown = false;
        }
    }
}
