using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjectDistructer : MonoBehaviour
{
    public float time;
    public bool deattachChilldrens;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
