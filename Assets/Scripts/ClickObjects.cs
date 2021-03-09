using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ClickObjects : MonoBehaviour
{

    [SerializeField] int _OIS, _OF, _IOC; //Objects In Scene, Objects Finded, Initial Objects Count;
    public GameObject[] _OEIS; //Objects Existing in Scene
    public Text text;

    void Start()
    {
        foreach (var Objects in _OEIS)
        {
            _OIS += 1;
        }

        _IOC = _OIS;
    }


    void Update()
    {
        if(_OIS <= 0)
        {
            FindObjectOfType<LevelLoader>().LoadNextScene();
        }

        text.text = "Objetos encontrados: " + _OF + "/" + _IOC;
    }

    public void DestroyObject(int _Quantity)
    {
        _OIS -= _Quantity;
        _OF += _Quantity;
    }    

}
