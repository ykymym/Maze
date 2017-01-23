using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
	public UnityEngine.UI.Text scoreLabel;
	public GameObject winnerLabelObject;

	public void Update()
	{
		int count = GameObject.FindGameObjectsWithTag ("Item").Length;
		scoreLabel.text = count.ToString ();

		if (count == 0) {
			//　オブジェクトをアクティブにする
			winnerLabelObject.SetActive (true);

			//ToMainSceneScript c1 = GetComponent<ToMainSceneScript>;

			if (SceneManager.GetActiveScene ().name == "stage1") {
				//DelayMethod(3.0f);
				Invoke("ToStage2", 3.0f);
				//SceneManager.LoadScene ("stage2");

			} else if (SceneManager.GetActiveScene ().name == "stage2") {
				//DelayMethod(3.0f);
				Invoke("ToStage3", 3.0f);
				//SceneManager.LoadScene ("stage2");

			} else if (SceneManager.GetActiveScene ().name == "stage3") {
				//DelayMethod(3.0f);
				Invoke("Title", 3.0f);
				//SceneManager.LoadScene ("stage2");
			}
		}
	}
	private IEnumerator DelayMethod(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		//action();
	}
	public void ToStage1() {

		System.Threading.Thread.Sleep(3000);

		SceneManager.LoadScene ("stage1");
	}

	public void ToStage2() {
		//Invoke ("stage2", 3.0f);
		SceneManager.LoadScene ("stage2");
	}

	public void ToStage3() {
		//Invoke ("stage2", 3.0f);
		SceneManager.LoadScene ("stage3");
	}

	public void Title() {

		SceneManager.LoadScene ("title");
	}
}