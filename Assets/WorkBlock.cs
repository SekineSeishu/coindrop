using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkBlock : MonoBehaviour
{
    [SerializeField]
    private GameObject getcoin;
    [SerializeField]
    private Vector3 initialPosition;
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(initialPosition.x, initialPosition.y, Mathf.Sin(Time.time) * speed + initialPosition.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent = getcoin.transform;
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.transform.parent = null;
    }
}
