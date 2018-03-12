using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyTextures : MonoBehaviour {

    GameObject[] bottom;
    public Transform bottomTextured;
	GameObject[] middle;
	public Transform middleTextured;
	GameObject[] bottom2x2;
	public Transform bottom2x2Textured;
	GameObject[] middle2x2;
	public Transform middle2x2Textured;

	// Use this for initialization
	void Start () {
        bottom = GameObject.FindGameObjectsWithTag("Bottom 1x1");
		middle = GameObject.FindGameObjectsWithTag ("mid 1x1");
		bottom2x2 = GameObject.FindGameObjectsWithTag("bottom 2x2");
		middle2x2 = GameObject.FindGameObjectsWithTag ("middle 2x2");

		foreach (GameObject e in bottom)
        {
			Vector3 place = e.transform.position;
			/*float tempy = e.transform.position.y - 2.5f;
			place.y = tempy;
			place.x = e.transform.position.x - 2.5f;
			place.z = e.transform.position.z + 2.5f;*/
			Transform t = Instantiate(bottomTextured, place, e.transform.rotation);
            t.parent = e.transform;
        }
		foreach (GameObject e in middle)
		{
			Vector3 place = e.transform.position;
			/*place.y = e.transform.position.y - 2.5f;
			place.x = e.transform.position.x - 2.5f;
			place.z = e.transform.position.z + 2.5f;*/
			Transform t = Instantiate(middleTextured, place, e.transform.rotation);
			t.parent = e.transform;
		}

		foreach (GameObject e in bottom2x2)
		{
			Vector3 place = e.transform.position;
			/*float tempy = e.transform.position.y - 2.5f;
			place.y = tempy;
			place.x = e.transform.position.x - 2.5f;
			place.z = e.transform.position.z + 2.5f;*/
			Transform t = Instantiate(bottom2x2Textured, place, e.transform.rotation);
			t.parent = e.transform;
		}
		foreach (GameObject e in middle2x2)
		{
			Vector3 place = e.transform.position;
			/*place.y = e.transform.position.y - 2.5f;
			place.x = e.transform.position.x - 2.5f;
			place.z = e.transform.position.z; + 2.5f;*/
			Transform t = Instantiate(middle2x2Textured, place, e.transform.rotation);
			t.parent = e.transform;
		}
	}
}
