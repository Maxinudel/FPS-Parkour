using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Caida : MonoBehaviour
{
    public float restart = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < restart)
        {

            Debug.Log("Respawm");
            SceneManager.LoadScene("FPS Parkour");
        }
    }
}
