using UnityEngine;
using System.Collections;

public class AndroidReceiveMessages : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AndroidJNI.AttachCurrentThread();
		AndroidJNIHelper.debug = true; 
		using (AndroidJavaClass jc = new AndroidJavaClass("com.mina.myapplication.MainActivity")) { 
			jc.CallStatic("UnitySendMessage", "Main Camera", "JavaMessage", "whoowhoo"); 
		}
	}

	// Update is called once per frame
	void Update () {
//		int RValue = 0;
//		using (AndroidJavaClass javaClass = new AndroidJavaClass("com.mina.myapplication.MainActivity")) {
//			using (AndroidJavaObject activity = javaClass.GetStatic<AndroidJavaObject>("mContext"))
//			{
//				Debug.Log("rate :"+activity.CallStatic<float>("getRate"));
//			}
//		}
//
//		//		Debug.Log("rate" + RValue.ToString() );
	}

	void receiveAlpha(string message) {
		Debug.Log("message from java: " + message);
	}

	void receiveEeg(string message) {
		Debug.Log("message from java: " + message);
	}

	void receiveAccel(string message) {
		Debug.Log("message from java: " + message);
	}

	void receiveStatus(string message) {
		Debug.Log("message from java: " + message);
	}
}