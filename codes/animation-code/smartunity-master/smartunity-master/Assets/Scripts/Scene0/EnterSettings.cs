using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterSettings : MonoBehaviour
{
    private GameObject start;
    public GameObject next;

    // Start is called before the first frame update
    void Start()
    {
        start = GameObject.Find("Background");
    }

    public void Click()
    {
        //将当前Panel隐藏，并将下一个界面打开，完成界面切换功能
        start.SetActive(false);
        next.SetActive(true);
    }
}
