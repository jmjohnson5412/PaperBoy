using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTexture : MonoBehaviour {

    private float repeatEvery = 40f;

	void Start () {
         gameObject.GetComponent<Renderer>().material.mainTextureScale = new Vector2(transform.localScale.x, transform.localScale.y);
    }
}
