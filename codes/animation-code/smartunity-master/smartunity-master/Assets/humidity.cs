using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class humidity : MonoBehaviour
{
    public float timer = 0;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Humidity/Text");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5 && timer < 1)
        {
            text.GetComponent<Text>().text = "当前湿度：76%rh ";
        }
        
        if (timer >= 113 && timer < 114)
        {
            text.GetComponent<Text>().text = "当前湿度：19.9%rh ";
        }
        if (timer >= 172.9 && timer < 173)
        {
            text.GetComponent<Text>().text = "当前湿度：50%rh ";
        }
        if (timer >= 299 && timer < 300)
        {
            text.GetComponent<Text>().text = "当前湿度：50%rh ";
        }
    }
}
