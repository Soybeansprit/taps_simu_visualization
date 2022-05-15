using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset;
    public GameObject player;
    public float smooth = 0.8f;

    void Start()
    {
        offset = player.transform.position;
    }

    void FixedUpdate()
    {
        Vector3 desPosition = this.transform.position + player.transform.position - offset;
        this.transform.position = Vector3.Lerp(this.transform.position, desPosition, smooth);
        offset = player.transform.position;
    }
}