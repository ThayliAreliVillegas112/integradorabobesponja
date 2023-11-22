using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float speedMultiplier = 1f;
    [SerializeField] private float accelerationFactor;
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        speedMultiplier += Time.deltaTime * accelerationFactor;

        //speedMultiplier = Mathf.Min(speedMultiplier, 2f);
        Time.timeScale = speedMultiplier;
    }
}
