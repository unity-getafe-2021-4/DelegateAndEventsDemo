using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinealObjectsSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;
    [SerializeField] int numberOfObjects;
    [SerializeField] float spaceBetweenObjects;
    void Start()
    {
        for (int i=0;i<numberOfObjects;i++)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (i * spaceBetweenObjects));
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], position, transform.rotation);
        }
    }
}
