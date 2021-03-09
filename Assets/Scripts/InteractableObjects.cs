using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObjects : MonoBehaviour
{
    EnumObjects _enumObjects;
    LevelLoader _levelLoader;

    void Start()
    {
        _enumObjects = FindObjectOfType<EnumObjects>();
        _levelLoader = FindObjectOfType<LevelLoader>();

    }

    private void OnMouseDown()
    {
        if (gameObject.tag == "bed")
        {
            _enumObjects._clickedObject = EnumObjects.Objects.bed;
            if (_levelLoader.currentSceneIndex != 6)
            {
                _enumObjects.DesactiveTrigger();
            }
        }
        else if (gameObject.tag == "flowers")
        {
            _enumObjects._clickedObject = EnumObjects.Objects.flowers;
            if (_levelLoader.currentSceneIndex != 6)
            {
                _enumObjects.DesactiveTrigger();
            }

        }
        else if (gameObject.tag == "gun")
        {
            _enumObjects._clickedObject = EnumObjects.Objects.gun;
            if (_levelLoader.currentSceneIndex != 6)
            {
                _enumObjects.DesactiveTrigger();
            }

        }
        else if (gameObject.tag == "medicine")
        {
            _enumObjects._clickedObject = EnumObjects.Objects.medicine;
            if (_levelLoader.currentSceneIndex != 6)
            {
                _enumObjects.DesactiveTrigger();
            }

        }
        else if (gameObject.tag == "television")
        {
            _enumObjects._clickedObject = EnumObjects.Objects.television;
            _enumObjects.DesactiveTrigger();

        }


    }

    void FunctionDesactive()
    {
        _enumObjects.DesactiveTrigger();


    }


    //foreach (var item in _triggers)
    //{
    //    if (_triggers[_objectClicked])
    //    {
    //        item.GetComponent<Collider2D>().enabled = false;
    //        _objectClicked += 1;
    //    }
    //}

}
