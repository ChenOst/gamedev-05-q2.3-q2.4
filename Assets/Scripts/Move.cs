using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float playerSpeed;
    private KeyCode right, left, up, down;
    // Start is called before the first frame update
    void Start()
    {
        // Identifies which player it is - and sets the keys accordingly
        if (this.gameObject == GameObject.Find("Player1"))
        {
            right = KeyCode.RightArrow;
            left = KeyCode.LeftArrow;
            up = KeyCode.UpArrow;
            down = KeyCode.DownArrow;
        }
        else if (this.gameObject == GameObject.Find("Player2"))
        {
            right = KeyCode.D;
            left = KeyCode.A;
            up = KeyCode.W;
            down = KeyCode.S;
        }
    }
    // Update is called once per frame
    void Update()
    {
        // Move Right
        if (Input.GetKey(right))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
        // Move Left
        if (Input.GetKey(left))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
        // Move Up
        if (Input.GetKey(up))
        {
            transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
        }
        // Move Down
        if (Input.GetKey(down))
        {
            transform.Translate(Vector3.down * playerSpeed * Time.deltaTime);
        }
    }
}
