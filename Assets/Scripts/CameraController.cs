using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        this.offset = this.transform.position - this.player.transform.position;    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Cam won't be set until player had moved
        this.transform.position = player.transform.position + offset;
    }
}
