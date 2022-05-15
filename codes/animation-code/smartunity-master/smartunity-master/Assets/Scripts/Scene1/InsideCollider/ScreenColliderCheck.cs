using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenColliderCheck : MonoBehaviour
{
    public GameObject obj;

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
            if (SaveGameData.Instance.MicOn)
                gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.blue;
            obj.SetActive(true);
            gameObject.GetComponent<OpenSettings>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.tag == "Character")
        {
            if (SaveGameData.Instance.MicOff)
                gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.white;
            obj.SetActive(false);
            gameObject.GetComponent<OpenSettings>().enabled = false;
        }
    }
}
