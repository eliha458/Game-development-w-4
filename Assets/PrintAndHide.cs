using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;

    int i = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ++i;
        Debug.Log($"{gameObject.name}:{i}");
    }
}
