using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    MeshRenderer meshRenderer;
    Rigidbody dropperRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        dropperRigidbody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        dropperRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("3초가 지났습니다.");
            meshRenderer.enabled = true;
            dropperRigidbody.useGravity = true;
        }
    }
}
