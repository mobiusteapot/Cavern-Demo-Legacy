using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ppt : MonoBehaviour
{
    public List<GameObject> list;
    public int count = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            count++;
            if (count > 5) count = 0;
        }

        for (int i = 0; i < 5; i++)
        {
            if (i != count)
            {
                list[i].SetActive (false);
            }
            else
            {
                list[i].SetActive(true);
            }
        }
    }
}
