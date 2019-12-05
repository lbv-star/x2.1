using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KivanoMenu : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject PCK;
    [SerializeField] GameObject U;
    [SerializeField] GameObject P;
    [SerializeField] GameObject Canvas;
    [SerializeField] GameObject exit;
    [SerializeField] GameObject cylinderWK;
    [SerializeField] GameObject cylinderBK;
    [SerializeField] GameObject cylinderZK;
    [SerializeField] GameObject cylinderUK;
    public float procentswaterkivano;
    public float procentsbelkikivano;
    public float procentszhirikivano;
    public float procentsuglevodikivano;
    static float l = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        float WK1 = procentswaterkivano * l / 100f;
        float WK = l - WK1;
        float sWK = WK / 1f;
        cylinderWK.transform.localScale -= new Vector3(0f, WK, 0f);
        cylinderWK.transform.position -= new Vector3(0f, 0f, sWK);

        float BK1 = procentsbelkikivano * l / 100f;
        float BK = l - BK1;
        float sBK = BK / 1f;
        cylinderBK.transform.localScale -= new Vector3(0, BK, 0);
        cylinderBK.transform.position -= new Vector3(0, 0, sBK);

        float ZK1 = procentszhirikivano * l / 100f;
        float ZK = l - ZK1;
        float sZK = ZK / 1f;
        cylinderZK.transform.localScale -= new Vector3(0, ZK, 0);
        cylinderZK.transform.position -= new Vector3(0, 0, sZK);

        float UK1 = procentsuglevodikivano * l / 100f;
        float UK = l - UK1;
        float sUK = UK / 1f;
        cylinderUK.transform.localScale -= new Vector3(0, UK, 0);
        cylinderUK.transform.position -= new Vector3(0, 0, sUK);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pushPCK ()
    {
        menu.SetActive(false);
        Canvas.SetActive(true);
        PCK.SetActive(true);
    }

    public void pushPCKb()
    {
        PCK.SetActive(false);
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

    public void pushExit ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("the first");
    }
}
