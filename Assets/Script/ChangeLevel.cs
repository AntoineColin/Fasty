using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeLevel : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if(collisionInfo.transform.tag == "Player"){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		}
	}
}
