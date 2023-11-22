using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isInside;
    private GameObject player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isInside)
        {
            player.GetComponent<Health>().GetDamage(Time.deltaTime);
            
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInside = true;
            other.GetComponent<Health>().GetDamage(5f);
            Debug.Log(other.name);
            player = other.gameObject;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInside = false;
            other.GetComponent<Health>().GetDamage(5f);
            Debug.Log(other.name);
        }
    }
}
