using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	float speed = 5f;

	private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
		controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void FixedUpdate()
	{
		float haxis = Input.GetAxis("Horizontal");
		float vaxis = Input.GetAxis("Vertical");

		Vector3 moveVector = new Vector3(haxis, -9.8f, vaxis) * speed * Time.fixedDeltaTime;
		controller.Move(moveVector);
	}
}
