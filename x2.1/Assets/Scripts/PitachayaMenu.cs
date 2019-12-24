using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitachayaMenu : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject PC;
    [SerializeField] GameObject U;
    [SerializeField] GameObject P;
    [SerializeField] GameObject Canvas;
    [SerializeField] GameObject cylinderW;
    [SerializeField] GameObject cylinderB;
    [SerializeField] GameObject cylinderZ;
    [SerializeField] GameObject cylinderU;
    public float procentswater;
    public float procentsbelki;
    public float procentszhiri;
    public float procentsuglevodi;
    static float l = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        float W1 = procentswater * l / 100f;
        float W = l - W1;
        float sW = W / 1f;
        cylinderW.transform.localScale -= new Vector3(0f, W, 0f);
        cylinderW.transform.position -= new Vector3(0f, 0f, sW);

        float B1 = procentsbelki * l / 100f;
        float B = l - B1;
        float sB = B / 1f;
        cylinderB.transform.localScale -= new Vector3(0, B, 0);
        cylinderB.transform.position -= new Vector3(0, 0, sB);

        float Z1 = procentszhiri * l / 100f;
        float Z = l - Z1;
        float sZ = Z / 1f;
        cylinderZ.transform.localScale -= new Vector3(0, Z, 0);
        cylinderZ.transform.position -= new Vector3(0, 0, sZ);

        float U1 = procentsuglevodi * l / 100f;
        float U = l - U1;
        float sU = U / 1f;
        cylinderU.transform.localScale -= new Vector3(0, U, 0);
        cylinderU.transform.position -= new Vector3(0, 0, sU);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pushPC()
    {
        menu.SetActive(false);
        Canvas.SetActive(true);
        PC.SetActive(true);
    }

    public void pushPCb()
    {
        PC.SetActive(false);
        Canvas.SetActive(false);
        menu.SetActive(true);
    }

    public void pushU()
    {
        menu.SetActive(false);
        Canvas.SetActive(true);
        U.SetActive(true);
    }

    public void pushUb()
    {
        U.SetActive(false);
        Canvas.SetActive(false);
        menu.SetActive(true);
    }

    public void pushP()
    {
        menu.SetActive(false);
        Canvas.SetActive(true);
        P.SetActive(true);
    }

    public void pushPb()
    {
        P.SetActive(false);
        Canvas.SetActive(false);
        menu.SetActive(true);
    }
}
