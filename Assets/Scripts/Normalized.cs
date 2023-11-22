using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normalized : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponentInChildren<Health>().NormalizedHeight(10f);
            Debug.Log(other.name);
            Destroy(gameObject);
        }

    }
}
