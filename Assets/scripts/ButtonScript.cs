using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public string _printText;
    public GameObject prefab;

    public void printText()
    {
        print(_printText);
    }

    public void playSound()
    {
        GetComponent<AudioSource>().Play();
    }
    public void instantiateRedCube()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
