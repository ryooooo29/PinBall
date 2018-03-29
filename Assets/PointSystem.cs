using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour {
	 float point;
	 float sumPoints;
	//pointコンポーネントを入れる
	 private GameObject pointsText;

	// Use this for initialization
	void Start () {
		//unity上のpointオブジェクトを取得
		this.pointsText = GameObject.Find ("Point");
	}
	


	void OnCollisionEnter(Collision abc){

		if (abc.gameObject.tag == "LargeStarTag") {
			point = 10;
		} else if (abc.gameObject.tag == "SmallCloudTag") {
			point = 20;
		} else if (abc.gameObject.tag == "LargeCloudTag") {
			point = 15;
		} else {
			point = 0;
		}

		sumPoints += point;

	}

//	 Update is called once per frame
	void Update () {

		Debug.Log (sumPoints,this);
		this.pointsText.GetComponent<Text> ().text = sumPoints.ToString();


	}

}

