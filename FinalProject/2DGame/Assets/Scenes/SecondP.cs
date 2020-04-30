using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondP : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite[] theallsprite;

    public Image theimage;

    int theindex = 0;

    private void OnEnable()
    {
        theindex = 0;
        InvokeRepeating("show1", 0, 0.08f);

    }
    void Start()
    {

    }


    void Update()
    {

    }

    void show1()
    {
        theimage.sprite = theallsprite[theindex];

        theindex++;

        theindex = theindex % 4;

    }

    private void OnDisable()
    {
        CancelInvoke("show1");
    }
}
