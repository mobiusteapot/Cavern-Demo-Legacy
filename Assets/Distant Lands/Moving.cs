using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float x, y, z;
    private bool rot = false, rise = false;
    private bool upb = false, downb = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.position += new Vector3(0, y, 0) * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position += new Vector3(0, -y, 0) * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * -25f); ;
        }
        if (Input.GetKey("right"))
        {
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * 25f); ;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(x, 0, -z) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(-x, 0, z) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(x, 0, z) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(-x, 0, -z) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.R))
        {
            rot = true;
        }
        if (Input.GetKey(KeyCode.T))
        {
            rise = true;
            upb = true;
        }
        if (Input.GetKey(KeyCode.N))
        {
            rot = false;
            rise = false;
        }
        if (rot)
        {
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * -150f); ;
        }
        if (rise)
        {
            if(upb)
                StartCoroutine(up());
            if(downb)
                StartCoroutine(down());

        }

    }

    IEnumerator up()
    {
        transform.position += new Vector3(0, y, 0) * Time.deltaTime*10;
        yield return new WaitForSeconds(1f);
        upb = false;
        downb = true;
    }

    IEnumerator down()
    {
        transform.position += new Vector3(0, y, 0) * Time.deltaTime * -10;
        yield return new WaitForSeconds(1f);
        upb = true;
        downb = false;
    }
}
