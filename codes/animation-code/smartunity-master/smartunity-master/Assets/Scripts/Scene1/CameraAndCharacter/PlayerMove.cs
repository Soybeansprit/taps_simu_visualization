using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator PlayerAnimator;
    public Camera myCamera;
    //public GameObject cameraPoint;
    private Rigidbody myRigidbody;

    public float moveSpeed = 2;
    //public float smooth = 1;
    //相机朝向
    private float cameraRotation;
    //private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = this.GetComponent<Rigidbody>();
        //offset = this.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 vel = myRigidbody.velocity;

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        if (Mathf.Abs(horizontal) > 0.05f || Mathf.Abs(vertical) > 0.05f)
        {
            float sinR = Mathf.Sin(cameraRotation);
            float cosR = Mathf.Cos(cameraRotation);
            myRigidbody.velocity = new Vector3((vertical * sinR + horizontal * cosR) * moveSpeed, 0, (vertical * cosR - horizontal * sinR) * moveSpeed);
            transform.rotation = Quaternion.LookRotation(new Vector3((vertical * sinR + horizontal * cosR), 0, (vertical * cosR - horizontal * sinR)));
        }

        AnimatorStateInfo info = PlayerAnimator.GetCurrentAnimatorStateInfo(0);

        if (vertical != 0 || horizontal != 0 && !info.IsName("Walk"))
        {
            PlayerAnimator.Play("Walk");
        }
        else if ((vertical == 0 && horizontal == 0 && info.IsName("Walk")))
        {
            PlayerAnimator.Play("Idle");
        }
    }
    /*
    void Update()
    {
        Vector3 desPosition = myCamera.transform.position + this.transform.position - offset;
        myCamera.transform.position = Vector3.Lerp(myCamera.transform.position, desPosition, Time.deltaTime);
        offset = this.transform.position;
    }*/

    void LateUpdate()
    {
        cameraRotation = myCamera.transform.eulerAngles.y / 180 * Mathf.PI;
    }
}
