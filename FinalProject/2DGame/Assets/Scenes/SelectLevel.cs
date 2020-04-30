using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public GameObject Plane1;
    public GameObject Plane2;
    public GameObject Plane3;
    void Start()
    {
        
    }
    public void ALevel1()
    {
        Plane1.SetActive(true);
    }
    public void ALevel2()
    {
        Plane2.SetActive(true);
    }
    public void ALevel3()
    {
        Plane3.SetActive(true);
    }
    public void AAClose()
    {
        Plane1.SetActive(false);
        Plane2.SetActive(false);
        Plane3.SetActive(false);
    }
    public void AW101()
    {
        SceneManager.LoadScene("W1-1");
    }
    public void AW102()
    {
        SceneManager.LoadScene("W1-2");
    }
    public void AW103()
    {
        SceneManager.LoadScene("W1-3");
    }
    public void AW201()
    {
        SceneManager.LoadScene("W2-1");
    }
    public void AW202()
    {
        SceneManager.LoadScene("W2-2");
    }
    public void AW203()
    {
        SceneManager.LoadScene("W2-3");
    }
    public void AW301()
    {
        SceneManager.LoadScene("W3-1");
    }
    public void AW302()
    {
        SceneManager.LoadScene("W3-2");
    }
    public void AW303()
    {
        SceneManager.LoadScene("W3-3");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
