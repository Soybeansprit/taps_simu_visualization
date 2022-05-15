using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Animator PlayerAnimator;

    public const int HERO_UP = 0;
    public const int HERO_RIGHT = 1;
    public const int HERO_DOWN = 2;
    public const int HERO_LEFT = 3;

    public int state = 0;

    public int moveSpeed = 2;

    public void Awake()
    {
        state = HERO_UP;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float KeyVertical = Input.GetAxis("Vertical");
        float KeyHorizontal = Input.GetAxis("Horizontal");

        if (KeyVertical < 0)
        {
            setHeroState(HERO_DOWN);    
        }
        else if (KeyVertical > 0)
        {
            setHeroState(HERO_UP);
        }

        if (KeyHorizontal < 0)
        {
            setHeroState(HERO_LEFT);
        }
        else if (KeyHorizontal > 0)
        {
            setHeroState(HERO_RIGHT);
        }

        AnimatorStateInfo info = PlayerAnimator.GetCurrentAnimatorStateInfo(0);

        if(KeyVertical != 0 || KeyHorizontal != 0 && !info.IsName("Walk"))
        {
            PlayerAnimator.Play("Walk");
        }
        else if((KeyVertical == 0 && KeyHorizontal == 0 && info.IsName("Walk")))
        {
            PlayerAnimator.Play("Idle");
        }
    }

    void setHeroState(int newState)
    {
        int rotateValue = (newState - state) * 90;
        Vector3 transformValue = new Vector3();

        switch (newState)
        {
            case HERO_UP:
                transformValue = -Vector3.forward * Time.deltaTime;
                break;
            case HERO_DOWN:
                transformValue = (Vector3.forward) * Time.deltaTime;
                break;
            case HERO_LEFT:
                transformValue = -Vector3.left * Time.deltaTime;
                break;
            case HERO_RIGHT:
                transformValue = (Vector3.left) * Time.deltaTime;
                break;
        }

        transform.Rotate(Vector3.up, rotateValue);

        transform.Translate(transformValue * moveSpeed, Space.World);
        state = newState;
    }
}
