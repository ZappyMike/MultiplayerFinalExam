using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class movement : MonoBehaviour
{
    public Joystick joystick;
    public PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        //joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            var rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = new Vector3(joystick.Horizontal * 30f, rigidbody.velocity.y, joystick.Vertical * 30f);
        }
    }

    public void SetJoysticks(GameObject camera) //*
    {
        Joystick[] tempJoystickList = camera.GetComponentsInChildren<Joystick>();
        foreach (Joystick temp in tempJoystickList)
        {
            if (temp.tag == "Joystick Movement")
                joystick = temp;
            //else if (temp.tag == "Joystick Camera")
                //camStick = temp;
        }

        /*Button[] tempButtonList = camera.GetComponentsInChildren<Button>();
        foreach (Button temp in tempButtonList)
        {
            if (temp.tag == "Jump Button")
                jumpButton = temp;
        }

        jumpButton.onClick.AddListener(JumpButtonPressed);
        */
        //cam = camera.transform;
    }
}
