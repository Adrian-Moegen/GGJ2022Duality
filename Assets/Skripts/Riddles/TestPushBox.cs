using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPushBox : MonoBehaviour
{

	[SerializeField] GameObject box;
	[SerializeField] GameObject box2;

	public float distance = 1f;
	public LayerMask boxMask;
	RaycastHit2D hit;


	void Start()
	{

	}


	void Update()
	{
		Physics2D.queriesStartInColliders = false;
		hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance, boxMask);

		PushInteract1();
		PushInteract2();
	}

	// could cause problem not protected when e is used at first without box

	private void PushInteract1()
    {

		if (hit.collider != null && hit.collider.gameObject.tag == "pushable" && Input.GetKeyDown("e"))
		{
			//box = hit.collider.gameObject;
			box.layer = LayerMask.NameToLayer("Player");



			//box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
			//box.GetComponent<FixedJoint2D>().enabled = true;
			//box.GetComponent<boxpull>().beingPushed = true;

		}
		else if (Input.GetKeyUp("e"))
		{

			box.layer = LayerMask.NameToLayer("Box");

			//box.GetComponent<FixedJoint2D>().enabled = false;
			//box.GetComponent<boxpull>().beingPushed = false;
		}
	}

	private void PushInteract2()
	{

		if (hit.collider != null && hit.collider.gameObject.tag == "pushable" && Input.GetKeyDown("e"))
		{
			//box = hit.collider.gameObject;
			box2.layer = LayerMask.NameToLayer("Player");



			//box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
			//box.GetComponent<FixedJoint2D>().enabled = true;
			//box.GetComponent<boxpull>().beingPushed = true;

		}
		else if (Input.GetKeyUp("e"))
		{

			box2.layer = LayerMask.NameToLayer("Box");

			//box.GetComponent<FixedJoint2D>().enabled = false;
			//box.GetComponent<boxpull>().beingPushed = false;
		}
	}


	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;

		Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);

	}
}
