using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveSubcameraIPDMod : MonoBehaviour
{
    [SerializeField] public CaveCamera cc;
    private List<OffAxisCam> caveCameras;
    private float ipd;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // press u to update new IPD value
        if (Input.GetKeyDown(KeyCode.U))
        {
            caveCameras = cc.caveCameras;
            ipd = cc.IPD;

            Debug.Log("U pressed");
            Debug.Log("List size " + caveCameras.Count);

            cc.AssembleCameras();
            //// do it for each eye
            //for (int eye = -1; eye <= 1; eye += 2)
            //{
            //    for(int i = 0; i < caveCameras.Count; i++)
            //    {
            //        // reset cam pos
            //        caveCameras[i].transform.position = new Vector3(0, 0, 0);

            //        // Rotate to face the plane
            //        caveCameras[i].transform.RotateAround(transform.up, (-0.5f * (CaveControls.panelCount360() - 3) + i - 1) * 2 * Mathf.PI / CaveControls.panelCount360());

            //        // Move to the side by IPD, keeping tangential to the inner circle
            //        float tangentAngle = CaveControls.singleton.radius * Mathf.Sin(Mathf.Sqrt(Mathf.Pow(ipd / 2, 2) * Mathf.Pow(CaveControls.singleton.radius, 2)));
            //        Vector3 tangentPos = Quaternion.AngleAxis(tangentAngle * Mathf.Rad2Deg, caveCameras[i].transform.up * eye) * caveCameras[i].transform.forward;
            //        caveCameras[i].transform.position = transform.position + tangentPos.normalized * ipd / 2000f;


            //    }
            //}
        }
    }
}
