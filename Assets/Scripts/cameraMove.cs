using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {

    public float horSpeed;
    public float verSpeed;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            float h = horSpeed * Input.GetAxis("Mouse X");
            float v = verSpeed * Input.GetAxis("Mouse Y");
            transform.Translate(h, v, 0);
        }

    }
}
