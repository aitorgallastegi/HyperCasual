using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float vSpeed = 5;
    public float hSpeed = 5;
    public Rigidbody rb;
    float horizontalInput;
    public float horizontalMultiplier = 2;
    bool alive = true;
    Vector3 forwardMove;
    Vector3 horizontalMove;
    float aceleration = 0.01f;//hay que definir el tipo de float, por eso la f al final


    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y <-3){
            Die();
        }
    }

    private void FixedUpdate(){
        if (!alive) return;

        vSpeed = vSpeed + aceleration;
        forwardMove = transform.forward * vSpeed * Time.fixedDeltaTime;
        horizontalMove = transform.right * horizontalInput * hSpeed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    public void Die(){
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
