using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int speed = 500;  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.W)){
            transform.position = transform.position + new Vector3(0, 0, 1) * speed * Time.deltaTime;
        }*/
        if (Keyboard.current != null && Keyboard.current.wKey.isPressed)
        {
            transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;

        }
        if (Keyboard.current != null && Keyboard.current.sKey.isPressed)
        {
            transform.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;

        }

        


    }

}
        