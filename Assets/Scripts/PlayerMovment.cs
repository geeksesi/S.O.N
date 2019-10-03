using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Vector3 mouse_position;
    public float move_speed = 0.05f;
    public Transform my_player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            mouse_position = Input.mousePosition;
            // mouse_position = Camera.main.ScreenToWorldPoint(mouse_position);
            transform.position = Vector2.Lerp(transform.position, mouse_position, move_speed);
            
        }
    }
}