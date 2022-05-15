using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temperature : MonoBehaviour
{
    public float timer = 0;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Temperature/Text");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 0.5 && timer < 1)
        {
            text.GetComponent<Text>().text = "当前温度：9℃ ";
        }
        if (timer >= 16.9 && timer < 17)
        {
            text.GetComponent<Text>().text = "当前温度：28.2℃ ";
        }
        if (timer >= 43.9 && timer < 44)
        {
            text.GetComponent<Text>().text = "当前温度：14.7℃ ";
        }
        if (timer >= 70.9 && timer < 71)
        {
            text.GetComponent<Text>().text = "当前温度：28.2℃ ";
        }
        if (timer >= 98 && timer < 99)
        {
            text.GetComponent<Text>().text = "当前温度：14.7℃ ";
        }
        if (timer >= 125 && timer < 126)
        {
            text.GetComponent<Text>().text = "当前温度：28.2℃ ";
        }
        if (timer >= 152 && timer < 153)
        {
            text.GetComponent<Text>().text = "当前温度：14.7℃ ";
        }
        if (timer >= 178.9 && timer < 179)
        {
            text.GetComponent<Text>().text = "当前温度：28.2℃ ";
        }
        if (timer >= 205.9 && timer < 206)
        {
            text.GetComponent<Text>().text = "当前温度：14.7℃ ";
        }
        if (timer >= 232.9 && timer < 233)
        {
            text.GetComponent<Text>().text = "当前温度：28.2℃ ";
        }
        if (timer >= 252.9 && timer < 253)
        {
            text.GetComponent<Text>().text = "当前温度：18.2℃ ";
        }
        if (timer >= 299 && timer < 200)
        {
            text.GetComponent<Text>().text = "当前温度：18.2℃ ";
        }
    }
}
