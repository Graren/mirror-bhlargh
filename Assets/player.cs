using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class player : MonoBehaviour {
	public float speed;
	Rigidbody2D rb;
	Transform trans;
	public float normalXScale;
	SkeletonAnimation skeletonAnimation;

	// Use this for initialization
	void Start () {
		skeletonAnimation = GetComponent<SkeletonAnimation>();
		rb = GetComponent<Rigidbody2D> ();
		trans = GetComponent<Transform> ();
		normalXScale = trans.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.velocity = new Vector2 (speed, rb.velocity.y);
			skeletonAnimation.AnimationName = "02_walk";
			trans.localScale = new Vector3 (normalXScale, trans.localScale.y, trans.localScale.z);
		}


		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.velocity = new Vector2 (-speed, rb.velocity.y);
			skeletonAnimation.AnimationName = "02_walk";
			trans.localScale = new Vector3 (-normalXScale, trans.localScale.y, trans.localScale.z);
		}


		if (Input.GetKey (KeyCode.Space)) {
			rb.velocity = new Vector2 (rb.velocity.x, speed);
			skeletonAnimation.AnimationName = "04_jump";
		}

		if (rb.velocity.magnitude < 0.1) {
			skeletonAnimation.AnimationName = "01_Idle";
		}
	}
}
