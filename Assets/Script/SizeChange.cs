using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{
    Vector3 baseSize, bigSize;
	Rigidbody2D rigibody2D;
	bool isBumper;

	void Start(){
		baseSize = transform.localScale;
		bigSize = baseSize*2.2f;
	}

    void Update()
    {
        if(Input.GetButton("Jump")){
			transform.localScale = bigSize;
		}else{
			transform.localScale = baseSize;
		}
    }
}
