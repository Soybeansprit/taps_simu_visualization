using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureControl : MonoBehaviour
{
    /// <summary>
    /// 默认显示值
    /// </summary>
    public float default_value = 0;

    /// <summary>
    /// 显示数值的UI屏
    /// </summary>
    public SpriteRenderer[] list_numbs;

    /*
    /// <summary>
    /// 数字的小数点各个位置
    /// </summary>
    public SpriteRenderer[] list_points;
    */

    /// <summary>
    /// 0-9为LED数字素材,10为不显示
    /// </summary>
    public Sprite[] list_lednumb;

    /*
    //显示小数点和隐藏小数点
    public Sprite sp_showPoint, sp_dontPoint;
    */

    /// <summary>
    /// 负数时显示
    /// </summary>
    public GameObject obj_negative;

    void Start()
    {
        if (default_value!=0)
        {
            ShowNumber(default_value, "f0");
        }
        ////测试
        //ShowText( 0.0005f, "f4");
    }

    void Update()
    {

    }

    public void ChangeTemperature(float value)
    {
        if (value != 0)
        {
            ShowNumber(value, "f0");
        }
        else
        {
            foreach (SpriteRenderer num in list_numbs)
            {
                num.sprite = list_lednumb[10];
            }
        }
    }

    //小数点位数
    int pointIndex = 0;
    internal void ShowNumber(float value, string format = "f1")
    {
        /*
        foreach (SpriteRenderer item in list_points)
        {
            item.sprite = sp_dontPoint;
        }
        */

        string str = value.ToString(format);

        /*
        pointIndex = 0;
        if (format == "f1")
        {
            pointIndex = 1;
            value = value * 10;
        }
        else if (format == "f2")
        {
            pointIndex = 2;
            value = value * 100;
        }
        else if (format == "f3")
        {
            pointIndex = 3;
            value = value * 1000;
        }
        else if (format == "f4")
        {
            pointIndex = 4;
            value = value * 10000;
        }
        else if (format == "f5")
        {
            pointIndex = 5;
            value = value * 100000;
        }
        //判断小数点的位置
        int showpoint = pointIndex - 1;
        if (showpoint >= 0 && showpoint < list_points.Length)
            list_points[showpoint].sprite = sp_showPoint;
        */

        //显示数值
        LetsGo((int)value);
    }
    internal void ShowNumber(int value)
    {
        pointIndex = 0;
        /*
        foreach (SpriteRenderer item in list_points)
        {
            item.sprite = sp_dontPoint;
        }
        */
        LetsGo(value);
    }
    public void LetsGo(int value)
    {
        if (value < 0)
        {
            value = -value;
            obj_negative.SetActive(true);
        }
        else
            obj_negative.SetActive(false);

        //将数值转字符串
        string str = value.ToString();
        int plus = pointIndex - str.Length;
        if (plus>=0)
        {
            string temp = string.Empty;
            for (int i = 0; i <= plus; i++)
            {
                temp += "0";
            }
            str = temp + str;
        }
        //显示的字符在最大个数内
        if (str.Length <= list_numbs.Length)
        {
            int j = str.Length - 1;
            for (int i = 0; i < str.Length; i++)
            {
                //显示数值
                list_numbs[i].sprite = list_lednumb[i];
                switch (str[j])
                {
                    case '0':
                        list_numbs[i].sprite = list_lednumb[0];
                        break;
                    case '1':
                        list_numbs[i].sprite = list_lednumb[1];
                        break;
                    case '2':
                        list_numbs[i].sprite = list_lednumb[2];
                        break;
                    case '3':
                        list_numbs[i].sprite = list_lednumb[3];
                        break;
                    case '4':
                        list_numbs[i].sprite = list_lednumb[4];
                        break;
                    case '5':
                        list_numbs[i].sprite = list_lednumb[5];
                        break;
                    case '6':
                        list_numbs[i].sprite = list_lednumb[6];
                        break;
                    case '7':
                        list_numbs[i].sprite = list_lednumb[7];
                        break;
                    case '8':
                        list_numbs[i].sprite = list_lednumb[8];
                        break;
                    case '9':
                        list_numbs[i].sprite = list_lednumb[9];
                        break;
                }
                j--;
            }
            if (list_numbs.Length > str.Length)
            {
                int startN = str.Length;
                int endN = list_numbs.Length;
                //更高位的数值隐藏
                for (int i = startN; i < endN; i++)
                {
                    list_numbs[i].sprite = list_lednumb[10];
                }
            }
        }
        //如果超出显示的最多数值
        else
        {
            SpriteRenderer _last = null;
            foreach (SpriteRenderer item in list_numbs)
            {
                item.sprite = list_lednumb[10];
                _last = item;
            }
            //显示无穷大
            _last.sprite = list_lednumb[1];
            /*
            foreach (SpriteRenderer item in list_points)
            {
                item.sprite = sp_dontPoint;
            }
            */
        }
    }
}
