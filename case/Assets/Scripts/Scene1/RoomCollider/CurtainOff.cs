using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainOff : MonoBehaviour
{
    private int waitTime;
    public GameObject[] curtain;
    private Animation ani;
    private float tick;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = SaveGameData.Instance.WaitCurtainOff;
        tick = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tick += Time.deltaTime;
        if (tick >= waitTime)
        {
            WaitCurtainOff();
        }
    }

    void WaitCurtainOff()
    {
        for (int i = 0; i < curtain.Length; ++i)
        {
            ani = curtain[i].GetComponent<Animation>();
            ani["Curtain" + i].time = ani["Curtain" + i].clip.length;
            ani["Curtain" + i].speed = -1.0f;
            ani.Play("Curtain" + i);
            SaveGameData.Instance.Curtain[i] = false;
        }
        tick = 0;
        gameObject.GetComponent<CurtainOff>().enabled = false;
    }
}
