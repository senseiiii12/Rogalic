using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform Player;
    public GameObject enemy;
    void Update()
    {
        
        Vector3 position = transform.position;
        position.x = Player.position.x;
        transform.position = position;
    }
    private void Start()
    {
        
    }

  
}
