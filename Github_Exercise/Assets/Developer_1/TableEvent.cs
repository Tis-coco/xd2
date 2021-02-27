using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RotationTable", 0,0.05f);
    }
    // Update is called once per frame
    void Update()
    {
    }
    private void RotationTable() {
        gameObject.GetComponent<Transform>().transform.Rotate(new Vector3(0,0,2));
    }
}
