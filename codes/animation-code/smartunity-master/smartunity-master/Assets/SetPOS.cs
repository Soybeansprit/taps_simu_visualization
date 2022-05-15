using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPOS : MonoBehaviour
{
    // lobby
    Vector3 location0 = new Vector3(-8.26f, 3.5f, 17.52f);
    Vector3 location1 = new Vector3(-52.9f, 3.5f, 4.0f);
    Vector3 location2 = new Vector3(41.0f, 3.5f, -2.3f);
    // 卫生间
    Vector3 location3 = new Vector3(-2.4f, 3.5f, 33.2f);
    // 厨房
    Vector3 location4 = new Vector3(-33.91f, 3.5f, 24.85f);
    // Start is called before the first frame update
    public float Timer = 0;
    GameObject posClone;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
       /* posClone = GameObject.Find("NextPos");
        this.transform.position = posClone.transform.position;
        Debug.Log(posClone.transform.position);
        Timer += Time.deltaTime;
        if(Timer >= 35 && Timer <= 36)
        {
            this.transform.position = location0;
        }
        if(Timer >= 80 && Timer <= 81)
        {
            this.transform.position = location1;
        }
        if (Timer >= 123 && Timer <= 124)
        {
            this.transform.position = location4;
        }
        if (Timer >= 164 && Timer <= 165)
        {
            this.transform.position = location3;
        }
        if (Timer >= 204 && Timer <= 205)
        {
            this.transform.position = location2;
        }*/

    }
}
