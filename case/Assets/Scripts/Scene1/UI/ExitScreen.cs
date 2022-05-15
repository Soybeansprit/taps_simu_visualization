using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitScreen : MonoBehaviour
{
    private Slider[] sliders;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        GameObject.FindGameObjectWithTag("Character").GetComponent<PlayerMove>().enabled = true;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMove>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        sliders = GameObject.Find("Settings").GetComponentsInChildren<Slider>();
        sliders[0].gameObject.GetComponent<ChangeFirstLight>().enabled = false;
        sliders[1].gameObject.GetComponent<ChangeSecondLight>().enabled = false;
        sliders[2].gameObject.GetComponent<ChangeThirdLight>().enabled = false;
        GameObject.Find("Settings").SetActive(false);
    }
}
