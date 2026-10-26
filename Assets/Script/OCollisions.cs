using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OCollisions : MonoBehaviour
{
    public GameObject o;
    public GameObject ho;
    public GameObject h2o;
    Color starterColor;
    GameObject element;
    float type = 0;

    // Start is called before the first frame update
    void Start()
    {
        element = InstantiatePrefab(o);
        element.transform.parent = gameObject.transform.parent;
    }

    public GameObject getElement()
    {
        return element;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision O");
        if (other.tag == "H")
        {
            if (other.gameObject.GetComponent<HCollisions>().IsElement())
            {
                if (type < 2)
                {
                    Debug.Log("Collision con H");
                    Destroy(element);
                    if (type == 0)
                        element = InstantiatePrefab(ho);
                    else if (type == 1)
                        element = InstantiatePrefab(h2o);
                    element.transform.parent = gameObject.transform.parent;
                    type++;
                    other.gameObject.GetComponent<HCollisions>().PassElement();
                }
            }
            else
            {
                if (other.tag == "H" && type > 0)
                {
                    Debug.Log("Collision con H");
                    Destroy(element);
                    type--;
                    if (type == 0)
                        element = InstantiatePrefab(o);
                    else if (type == 1)
                        element = InstantiatePrefab(ho);
                    element.transform.parent = gameObject.transform.parent;
                    other.gameObject.GetComponent<HCollisions>().GetElement();
                }
            }
        }
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
}