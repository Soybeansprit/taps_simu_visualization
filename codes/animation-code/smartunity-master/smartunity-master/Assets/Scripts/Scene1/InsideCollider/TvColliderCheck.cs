using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvColliderCheck : MonoBehaviour
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
            if (SaveGameData.Instance.TvOn)
                gameObject.GetComponent<TvOn>().enabled = true;
            if (SaveGameData.Instance.TvOff)
                gameObject.GetComponent<TvOff>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.tag == "Character")
        {
            if (SaveGameData.Instance.TvOn)
                gameObject.GetComponent<TvOn>().enabled = false;
            if (SaveGameData.Instance.TvOff)
                gameObject.GetComponent<TvOff>().enabled = true;
        }
    }
}
