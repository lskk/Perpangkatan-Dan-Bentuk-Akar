using UnityEngine;
using System.Collections;

public class jalanjalan : MonoBehaviour {

    float maxSpeed = 5f;
   // float rotSpeed = 180f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //putar
        //Quaternion rot = transform.rotation;

        //float z = rot.eulerAngles.z;

        //z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        //rot = Quaternion.Euler(0,0,z);

        //transform.rotation=rot;

        // pindah
        Vector3 pos = transform.position;

        //Vector3 velocity= new Vector3(0, Input.GetAxis("Vertical")* maxSpeed * Time.deltaTime,0);

        //pos += rot * velocity;

        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        transform.position = pos;

        Vector3 pos1 = transform.position;

        //Vector3 velocity= new Vector3(0, Input.GetAxis("Vertical")* maxSpeed * Time.deltaTime,0);

        //pos += rot * velocity;

        pos1.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
        transform.position = pos1;
	}
}
