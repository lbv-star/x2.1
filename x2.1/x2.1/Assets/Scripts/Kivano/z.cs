using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z : MonoBehaviour
{
    public float c;
    static float l = 0.3f;


    [SerializeField] private GameObject cylinder;
    // Start is called before the first frame update
    void Start()
    {
        float dc1 = c * l / 100f;
        float dc = l - dc1;
        float s = dc / 8f;
        cylinder.transform.localScale -= new Vector3(0, dc, 0);
        cylinder.transform.position -= new Vector3(0, 0, s);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
