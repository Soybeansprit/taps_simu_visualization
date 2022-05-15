using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCurrentValue : MonoBehaviour
{
    private float value;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        value = gameObject.GetComponentInParent<Slider>().value;
        gameObject.GetComponent<Text>().text = "当前值： " + value;
    }
}
