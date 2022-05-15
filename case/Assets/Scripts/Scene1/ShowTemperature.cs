using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ShowTemperature : MonoBehaviour
{
    private TemperatureControl[] tControl;
    private float offset;
    private float realT;
    private float wait;
    private string filePath;
    private StringReader sr;
    private string[] lineData;

    // Start is called before the first frame update
    void Start()
    {
        tControl = gameObject.GetComponentsInChildren<TemperatureControl>();
        tControl[0].ChangeTemperature(SaveGameData.Instance.InitialTemperature);
        //offset = SaveGameData.Instance.Temperature - SaveGameData.Instance.InitialTemperature;
        realT = SaveGameData.Instance.InitialTemperature;
        wait = 0;
        //filePath = "D:\\_work\\FinalDesign\\Modelica\\AirCurrentT.csv";
        sr = new StringReader(filePath);
        sr.ReadLine();
    }
    
    // Update is called once per frame
    //不与OpenModelica连通时使用此Update
    void Update()
    {
        tControl[1].ChangeTemperature(SaveGameData.Instance.Temperature);
        wait += Time.deltaTime;
        if (wait >= 1)
        {
            realT += offset / 100;
            offset = SaveGameData.Instance.Temperature - realT;
            SaveGameData.Instance.InitialTemperature = (int)realT;
            tControl[0].ChangeTemperature(SaveGameData.Instance.InitialTemperature);
            wait = 0;
        }
    }
    /*
     *与OpenModelica连通时使用此Update与ReadCsvFile
    void Update()
    {
        tControl[1].ChangeTemperature(SaveGameData.Instance.Temperature);
        wait += Time.deltaTime;
        if(wait >= 0.2)
        {
            realT = ReadCsvFile();
            SaveGameData.Instance.InitialTemperature = (int)realT;
            tControl[0].ChangeTemperature(SaveGameData.Instance.InitialTemperature);
            wait = 0;
        }
    }

    private float ReadCsvFile()
    {
        lineData = sr.ReadLine().Split(new char[] { ',' });
        return System.Convert.ToSingle(lineData[1]);
    }*/
}
