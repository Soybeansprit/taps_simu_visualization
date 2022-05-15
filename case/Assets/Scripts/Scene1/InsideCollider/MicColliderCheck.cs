using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicColliderCheck : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Character")
        {
            if(SaveGameData.Instance.MicOn)
            gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.blue;
        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.tag == "Character")
        {
            if(SaveGameData.Instance.MicOff)
            gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.white;
        }
    }
}
