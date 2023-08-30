using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;

    int i = 3;
    private int a;

    void Start()
    {
        Random rnd = new Random();
        a = rnd.Next(150, 251);

    }

    // Update is called once per frame
    void Update()
    {
        ++i;
        Debug.Log($"{gameObject.name}:{i}");

        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.CompareTag("Blue") && i == a)
        {
            gameObject.SetActive(false);
        }
    }
}
