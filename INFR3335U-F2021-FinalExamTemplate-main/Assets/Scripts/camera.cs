using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class camera : MonoBehaviour
{
    public Joystick joystick;

    public GameObject player;
    private Vector3 offset;

    private float rotx;
    private float roty;
    private Vector3 rotateValue;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
            roty = joystick.Horizontal;
            rotx = joystick.Vertical;
            rotateValue = new Vector3(rotx, roty * -1, 0);
            transform.eulerAngles = transform.eulerAngles - rotateValue;
    }
    private void LateUpdate()
    {
            transform.position = player.transform.position + offset;
            transform.position += new Vector3(0, 2, -2);
    }
}
