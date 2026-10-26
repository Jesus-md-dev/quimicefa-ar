using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskCollision : MonoBehaviour
{
    public GameObject[] tasks;

    GameObject element;

    void Start()
    {
        element = CreateTask();
        element.transform.parent = gameObject.transform.parent;
    }

    private GameObject CreateTask()
    {
        Destroy(element);
        GameObject el = Instantiate(tasks[Random.Range(0, tasks.Length)],
        new Vector3(transform.position.x
            , transform.position.y + 3.5f
            , transform.position.z),
        new Quaternion(0, 0, 0, 0));
        el.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        return el;
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Task Collision");
        if (other.tag == "O")
        {
            if (other.gameObject.GetComponent<OCollisions>().getElement().name == element.name)
            {
                element = CreateTask();
                element.transform.parent = gameObject.transform.parent;
            }
        }
        else if(other.tag == "H")
        {
            if(other.gameObject.GetComponent<HCollisions>().IsElement())
            {
                if(other.gameObject.GetComponent<HCollisions>().getElement().name == element.name)
                {
                    element = CreateTask();
                    element.transform.parent = gameObject.transform.parent;
                }
            }
        }
    }
}