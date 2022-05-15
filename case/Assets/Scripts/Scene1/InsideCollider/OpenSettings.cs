using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSettings : MonoBehaviour
{
    public GameObject obj;
    public Animator PlayerAnimator;
    private Slider[] sliders;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            obj.SetActive(true);
            GameObject.FindGameObjectWithTag("Character").GetComponent<PlayerMove>().enabled = false;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMove>().enabled = false;
            sliders = obj.GetComponentsInChildren<Slider>();
            sliders[0].gameObject.GetComponent<ChangeFirstLight>().enabled = false;
            sliders[0].gameObject.GetComponent<ChangeFirstLight>().enabled = true;
            sliders[1].gameObject.GetComponent<ChangeSecondLight>().enabled = false;
            sliders[1].gameObject.GetComponent<ChangeSecondLight>().enabled = true;
            sliders[2].gameObject.GetComponent<ChangeThirdLight>().enabled = false;
            sliders[2].gameObject.GetComponent<ChangeThirdLight>().enabled = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            PlayerAnimator.Play("Idle");
        }
    }
}
