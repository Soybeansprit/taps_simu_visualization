using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainOn : MonoBehaviour
{
    private int waitTime;
    public GameObject[] curtain;
    private Animation ani;
    private float tick;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = SaveGameData.Instance.WaitCurtainOn;
        tick = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tick += Time.deltaTime;
        if (tick >= waitTime)
        {
            WaitCurtainOn();
        }
    }

    void WaitCurtainOn()
    {
        for (int i = 0; i < curtain.Length; ++i)
        {
            ani = curtain[i].GetComponent<Animation>();
            ani["Curtain" + i].speed = 1.0f;
            ani.Play("Curtain" + i);
            SaveGameData.Instance.Curtain[i] = true;
        }
        tick = 0;
        gameObject.GetComponent<CurtainOn>().enabled = false;
    }
}
