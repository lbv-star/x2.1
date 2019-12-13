using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public ParticleSystem Lightning;

    private void OnMouseDown()
    {
        Lightning.Stop();
        var vec = gameObject.transform.position - Lightning.transform.position;
        var distance = vec.magnitude;
        Lightning.GetComponent<ParticleSystemRenderer>().lengthScale = distance;
        Lightning.transform.LookAt(gameObject.transform);
        Lightning.transform.Rotate(new Vector3(0, 180, 0));
        Lightning.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }
}
