using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public int age;

    [SerializeField]
    private Vector3 destination;
    [SerializeField, Range(1f, 5f)]
    private float speed = 3f;
    
    public void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, destination, speed * Time.deltaTime);

        Debug.Log(this.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Person")
        {
            Debug.LogError("collided");
            Time.timeScale = 0;
        }
    }
}
