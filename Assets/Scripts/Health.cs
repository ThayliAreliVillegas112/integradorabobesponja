using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame
    [SerializeField] private float maxHealth;
    private float currentHealth;
    void Start()
    {
        currentHealth=maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    public void GetDamage(float damage)
    {
        currentHealth=Mathf.Max(currentHealth- damage,0);
        //currentHealth-=damage;
        Debug.Log(currentHealth);
    }
    //public void RecoverHealth(float amount)
    //{
    //    //currentHealth += amount;
    //    currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
    //    Debug.Log(currentHealth);
    //    //transform.localScale *= 2f; aumentar el tamaño del personaje
    //    //GetComponent<ThirdPersonMovement>().speed *= 2f; aumentar la velocidad
    //    //GetComponent<ThirdPersonMovement>().speed*=2f;
    //    //transform.localScale *= 2f;

    //}

    public void RecoverHealth(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        Debug.Log(currentHealth);
        //transform.localScale *= 2f; aumentar el tamaño del personaje
        //GetComponent<ThirdPersonMovement>().speed *= 2f; aumentar la velocidad
        //GetComponent<ThirdPersonMovement>().speed*=2f;
        //transform.localScale *= 2f;


    }

    public void DuplicatedHeight(float amount)
    {
        //currentHealth += amount;
        //currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        //Debug.Log(currentHealth);
        //transform.localScale *= 2f; aumentar el tamaño del personaje
        //GetComponent<ThirdPersonMovement>().speed *= 2f; aumentar la velocidad
        //GetComponent<ThirdPersonMovement>().speed*=2f;
        transform.localScale *= 2f;


    }

    public void NormalizedHeight(float amount)
    {
        //currentHealth += amount;
        //currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        //Debug.Log(currentHealth);
        //transform.localScale *= 2f; aumentar el tamaño del personaje
        //GetComponent<ThirdPersonMovement>().speed *= 2f; aumentar la velocidad
        //GetComponent<ThirdPersonMovement>().speed*=2f;
        transform.localScale *= 1f;


    }

}
