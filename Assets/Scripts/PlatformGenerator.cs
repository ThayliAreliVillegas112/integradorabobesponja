using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private float time;
    private float timeCounter;
    [SerializeField] private float maxXScale;
    [SerializeField] private float minXScale;
    void Start()
    {
        timeCounter = time;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter-=Time.deltaTime;
        if (timeCounter <= 0)
        {
            GameObject instance=Instantiate(platformPrefab, transform.position, Quaternion.identity, this.transform);
            instance.transform.localScale = new Vector3(
                Random.Range(minXScale,maxXScale),
                instance.transform.localScale.y,
                instance.transform.localScale.z
                );
            timeCounter = time;
        }
    }
}
