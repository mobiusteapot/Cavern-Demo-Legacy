using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StereoMod : MonoBehaviour
{
    public Camera cam;
    public Text septxt;
    public Text ipdtxt;
    public CaveCamera cc;
    public Text contxt;

    // Start is called before the first frame update
    void Start()
    {
        //cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey("[7]"))
        //{
        //    cam.stereoSeparation += cam.stereoSeparation * 0.1f;
        //}
        //if (Input.GetKey("[1]"))
        //{
        //    cam.stereoSeparation -= cam.stereoSeparation * 0.1f;
        //}
        if (Input.GetKeyDown("[8]"))
        {
            cc.IPD += 10;
        }
        if (Input.GetKeyDown("[2]"))
        {
            cc.IPD -= 10;
        }
        //if (Input.GetKey("[9]"))
        //{
        //    cam.stereoConvergence += cam.stereoConvergence * 0.1f;
        //}
        //if (Input.GetKey("[3]"))
        //{
        //    cam.stereoConvergence -= cam.stereoConvergence * 0.1f;
        //}
        // septxt.text=cam.stereoSeparation.ToString();
        ipdtxt.text = cc.IPD.ToString();
        // contxt.text = cam.stereoConvergence.ToString();
    }
}
