using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    //solo si estas seguro que existe ese objecto
    private CharacterController chController;
    public float speed;
    private float gravity;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float jumpForce;
    private Animator animator;

    //awake y start, el awake se ejecuta antes del start 
    void Awake()
    {
        chController = GetComponent<CharacterController>();
        animator= GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        //saber si se esta presionando la tecla
        Vector2 inputVector =new Vector2( 
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
            );

        if(!chController.isGrounded)
        {
            gravity += Physics.gravity.y*Time.deltaTime;
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);
            gravity = Physics.gravity.y * 0.1f;
        }

        Vector3 movementVector=Camera.main.transform.forward*inputVector.y+Camera.main.transform.right*inputVector.x;

        movementVector.y = 0f;

        if (Input.GetKeyDown(KeyCode.Space) && chController.isGrounded) {
            gravity = jumpForce;
            
        }

        Vector3 composedVector = new Vector3(
            0f,
            gravity,
            0f
            );


        chController.Move(movementVector * speed * Time.deltaTime + composedVector*Time.deltaTime);
        //Vector2.zero es igual a 0 en x y 0 en y. Vector2(0,0)



        //Move ya toma en cuenta colisiones, pide un vector 3 con colisiones
        //GetAxisRaw pasa tal cual el valor 

        //Para mover
        //Vector3 movementVector = new Vector3(
        //    inputVector.x,
        //    0f,
        //    inputVector.y
        //    );

       // Vector3 movementVector =Camera.main.transform.forward * inputVector.y + Camera.main.transform.right*inputVector.x;

       // movementVector.y = 0f;

       //chController.Move(movementVector.normalized * speed * Time.deltaTime);

        //Proceso de recortar el vector se le llama la normalizacion
        //El vector siempre tiene la magnitud de una velocidad 
        if (inputVector != Vector2.zero)
        {
            //transform.rotation = Quaternion.LookRotation(movementVector);
            Quaternion targetRotation = Quaternion.LookRotation(movementVector);
            //partida rotacion actual, a donde vamos a interporlar, incremento
            transform.rotation=Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
            animator.SetFloat("movementSpeed", 1f);
        }
        else
        {
            animator.SetFloat("movementSpeed", 0f);
        }

        
    }
}
