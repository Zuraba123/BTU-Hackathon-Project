using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterMovementbackup : MonoBehaviour
{
    public GameObject sword;
    public GameObject Enemy;
    public int enhp;
    public Transform Player;
    public float rotationSpeed;
    public Animator animator;
    void Start ()
        {
            animator = GetComponent<Animator>();
        }
    void OnTriggerEnter (Collider otherCollider)
    {
        Debug.Log("Enemy!");
        if(Input.GetMouseButton(0) && otherCollider.gameObject.gameObject == Enemy)
            {
                animator.SetBool("attack", true);
                Debug.Log("Enemy!");
                Destroy(Enemy);
            }
    }
    void Update ()
    {
        if (enhp == 0)
        {
            Destroy(Enemy);
        }
        if (Input.GetMouseButton(0))
        {
            animator.SetBool("attack", true);
        }
        {
            if (Input.GetMouseButtonUp(0))
                animator.SetBool("attack", false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Player.position = Player.position + Player.forward * 2f;
            animator.SetBool("idle", false);
            animator.SetBool("run", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("idle", true);
            animator.SetBool("run", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Player.position = Player.position - Player.forward * 2f;
            animator.SetBool("idle", false);
            animator.SetBool("run", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("idle", true);
            animator.SetBool("run", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, rotationSpeed);
        }
    }
}
