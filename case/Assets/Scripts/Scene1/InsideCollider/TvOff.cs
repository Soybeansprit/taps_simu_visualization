using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvOff : MonoBehaviour
{
    private int waitTime;
    public GameObject tv;
    public Material material;
    private float tick;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = SaveGameData.Instance.WaitTvOff;
        tick = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tick += Time.deltaTime;
        if (tick >= waitTime)
        {
            WaitTvOff();
        }
    }

    void WaitTvOff()
    {
        tv.GetComponent<Renderer>().material = material;
        tick = 0;
        gameObject.GetComponent<TvOff>().enabled = false;
    }
}
