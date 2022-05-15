using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private GameObject player;
    private Transform playerTF;

    //dirVector为相机的朝向
    private Vector3 dirVector;
    public float distance;

    private float MouseX;
    private float MouseY;
    public float speed;
    public float bottomLimitAngle;
    private float bottomLimit; //the cos value

    // Start is called before the first frame update
    void Start()
    {
        //隐藏鼠标光标
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        player = GameObject.FindGameObjectWithTag("Player");
        playerTF = player.transform;

        dirVector = Vector3.Normalize(playerTF.position - transform.position);
        transform.position = playerTF.position + distance * (-dirVector);

        MouseX = 0;
        MouseY = 0;
        bottomLimit = Mathf.Cos(bottomLimitAngle / 180 * Mathf.PI);
    }

    // Update is called once per frame
    void Update()
    {
        //使相机始终看向角色位置
        transform.LookAt(playerTF);

        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y");

        //当Y轴移动角度超过限制时，相机不移动
        if (Vector3.Dot(-dirVector.normalized, -playerTF.up.normalized) > bottomLimit)
        {
            if (MouseY > 0)
                MouseY = 0;
        }

        //调整相机位置
        transform.RotateAround(playerTF.position, playerTF.up, speed * MouseX);
        transform.RotateAround(playerTF.position, -VerticalRotateAxis(dirVector), speed * MouseY);

        dirVector = Vector3.Normalize(playerTF.position - transform.position);
    }

    Vector3 VerticalRotateAxis(Vector3 dirVector)
    {
        Vector3 playerToCamera = -dirVector.normalized;
        float x = playerToCamera.x;
        float z = playerToCamera.z;
        Vector3 rotateAxis = Vector3.zero;
        rotateAxis.z = Mathf.Sqrt(x * x / (x * x + z * z));
        rotateAxis.x = Mathf.Sqrt(z * z / (x * x + z * z));
        if (x >= 0)
        {
            if (z >= 0)
            {
                rotateAxis.x = -rotateAxis.x;
            }
        }
        else
        {
            if (z >= 0)
            {
                rotateAxis.x = -rotateAxis.x;
                rotateAxis.z = -rotateAxis.z;
            }
            else
            {
                rotateAxis.z = -rotateAxis.z;
            }
        }
        return rotateAxis;
    }
}
