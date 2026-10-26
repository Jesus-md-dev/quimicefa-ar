using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HCollisions : MonoBehaviour
{
    public GameObject h;
    GameObject element;
    public bool isElement;

    // Start is called before the first frame update
    void Start()
    {
        element = InstantiatePrefab(h);
        element.transform.parent = gameObject.transform.parent;
        isElement = true;
    }

    public bool IsElement()
    {
        return isElement;
    }

    public GameObject getElement()
    {
        return element;
    }

    private GameObject InstantiatePrefab(GameObject prefab)
    {
        GameObject el = Instantiate(prefab,
        new Vector3(transform.position.x
            , transform.position.y + 3.5f
            , transform.position.z),
        new Quaternion(0, 0, 0, 0));
        return el;
    }

    public void PassElement()
    {
        Destroy(element);
        isElement = false;
    }

    public void GetElement()
    {
        element = InstantiatePrefab(h);
        element.transform.parent = gameObject.transform.parent;
        isElement = true;
    }
}