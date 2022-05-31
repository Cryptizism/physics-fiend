using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControllerScript : MonoBehaviour
{
    public GameObject ButtonW;
    public GameObject ButtonA;
    public GameObject ButtonD;

    public GameObject ButtonSpace;

    public GameObject ButtonUp;
    public GameObject ButtonLeft;
    public GameObject ButtonRight;

    public Sprite WOpen;
    public Sprite WClosed;

    public Sprite AOpen;
    public Sprite AClosed;

    public Sprite DOpen;
    public Sprite DClosed;

    public Sprite SpaceOpen;
    public Sprite SpaceClosed;

    public Sprite UpOpen;
    public Sprite UpClosed;

    public Sprite LeftOpen;
    public Sprite LeftClosed;

    public Sprite RightOpen;
    public Sprite RightClosed;

    private SpriteRenderer _buttonW_renderer;
    private SpriteRenderer _buttonA_renderer;
    private SpriteRenderer _buttonD_renderer;

    private SpriteRenderer _buttonSpace_renderer;

    private SpriteRenderer _buttonUp_renderer;
    private SpriteRenderer _buttonLeft_renderer;
    private SpriteRenderer _buttonRight_renderer;

    // Start is called before the first frame update
    void Start()
    {
        _buttonW_renderer = ButtonW.GetComponent<SpriteRenderer>();
        _buttonA_renderer = ButtonA.GetComponent<SpriteRenderer>();
        _buttonD_renderer = ButtonD.GetComponent<SpriteRenderer>();

        _buttonSpace_renderer = ButtonSpace.GetComponent<SpriteRenderer>();

        _buttonUp_renderer = ButtonUp.GetComponent<SpriteRenderer>();
        _buttonLeft_renderer = ButtonLeft.GetComponent<SpriteRenderer>();
        _buttonRight_renderer = ButtonRight.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            _buttonSpace_renderer.sprite = SpaceClosed;
        } 
        else if (Input.GetKeyUp("space"))
        {
            _buttonSpace_renderer.sprite = SpaceOpen;
        }
        else if (Input.GetKeyDown("w"))
        {
            _buttonW_renderer.sprite = WClosed;
        }
        else if (Input.GetKeyUp("w"))
        {
            _buttonW_renderer.sprite = WOpen;
        }
        else if (Input.GetKeyDown("a"))
        {
            _buttonA_renderer.sprite = AClosed;
        }
        else if (Input.GetKeyUp("a"))
        {
            _buttonA_renderer.sprite = AOpen;
        }
        else if (Input.GetKeyDown("d"))
        {
            _buttonD_renderer.sprite = DClosed;
        }
        else if (Input.GetKeyUp("d"))
        {
            _buttonD_renderer.sprite = DOpen;
        }
        else if (Input.GetKeyDown("left"))
        {
            _buttonLeft_renderer.sprite = LeftClosed;
        }
        else if (Input.GetKeyUp("left"))
        {
            _buttonLeft_renderer.sprite = LeftOpen;
        }
        else if (Input.GetKeyDown("right"))
        {
            _buttonRight_renderer.sprite = RightClosed;
        }
        else if (Input.GetKeyUp("right"))
        {
            _buttonRight_renderer.sprite = RightOpen;
        }
        else if (Input.GetKeyDown("up"))
        {
            _buttonUp_renderer.sprite = UpClosed;
        }
        else if (Input.GetKeyUp("up"))
        {
            _buttonUp_renderer.sprite = UpOpen;
        }
    }
}
