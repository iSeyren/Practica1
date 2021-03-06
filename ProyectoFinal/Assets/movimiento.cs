using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        if (transform.position.x < -10)
            transform.position = new Vector3(-10, -3);
        else if (transform.position.x > 10)
            transform.position = new Vector3( 10, -3);
    }
    public void OnCollisionEnter()
    {
        SceneManager.LoadScene("ProyectoFinal");
    }
}
