using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubos : MonoBehaviour
{
    public float Delay = 0.1f;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Inicio", Delay, Delay);
        
    }

    // Update is called once per frame
    void Inicio()
    {
        Instantiate(cube, new Vector3(Random.Range(-10, 10), 10, 0),Quaternion.identity);
    }
}
