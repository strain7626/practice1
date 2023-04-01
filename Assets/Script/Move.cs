using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rigid;
    public int jump_power;

    public GameObject snowball;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if(Input.GetButtonDown("Jump"))
            rigid.AddForce(transform.up * jump_power, ForceMode.Impulse);
        if (Input.GetKeyDown("f"))
        {
            GameObject B = Instantiate(snowball, transform.position + new Vector3(0,3,2), transform.rotation);
            Rigidbody rigid = B.GetComponent<Rigidbody>();
            rigid.AddForce(transform.forward * 100, ForceMode.Impulse);
            rigid.AddForce(transform.up * 10, ForceMode.Impulse);
        }
    }
}
    