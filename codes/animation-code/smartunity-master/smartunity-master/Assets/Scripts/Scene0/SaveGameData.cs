using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameData : MonoBehaviour
{
    public static SaveGameData Instance { get; private set; }

    public bool FirstGroupLightOn { get; set; } = true;
    public bool SecondGroupLightOn { get; set; } = true;
    public bool ThirdGroupLightOn { get; set; } = true;
    public int WaitFirstGroupLightOn { get; set; } = 0;
    public int WaitSecondGroupLightOn { get; set; } = 0;
    public int WaitThirdGroupLightOn { get; set; } = 0;

    public bool FirstGroupLightOff { get; set; } = true;
    public bool SecondGroupLightOff { get; set; } = true;
    public bool ThirdGroupLightOff { get; set; } = true;
    public int WaitFirstGroupLightOff { get; set; } = 0;
    public int WaitSecondGroupLightOff { get; set; } = 0;
    public int WaitThirdGroupLightOff { get; set; } = 0;

    public bool AirOn { get; set; } = true;
    public int WaitAirOn { get; set; } = 0;
    public bool AirOff { get; set; } = true;
    public int WaitAirOff { get; set; } = 0;

    public bool CurtainOn { get; set; } = true;
    public int WaitCurtainOn { get; set; } = 0;
    public bool CurtainOff { get; set; } = true;
    public int WaitCurtainOff { get; set; } = 0;

    public bool TvOn { get; set; } = true;
    public int WaitTvOn { get; set; } = 0;
    public bool TvOff { get; set; } = true;
    public int WaitTvOff { get; set; } = 0;

    public bool MicOn { get; set; } = true;
    public bool MicOff { get; set; } = true;

    public string AirMode { get; set; } = "制冷";
    public int Temperature { get; set; } = 26;
    public int InitialTemperature { get; set; } = 36;
    public float NormalLightIntensity { get; set; } = 0.5f;
    public string NormalCurtainState { get; set; } = "打开";
    public float CastLightIntensity { get; set; } = 0;
    public string CastCurtainState { get; set; } = "关闭";
    public float CurrentFirstLightIntensity { get; set; } = 0;
    public float CurrentSecondLightIntensity { get; set; } = 0;
    public float CurrentThirdLightIntensity { get; set; } = 0;

    public bool[] Curtain { get; set; } = { false, false, false, false };

    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
