using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToMainScene : MonoBehaviour{
	
	public void ToStage1() {

		System.Threading.Thread.Sleep(3000);

		SceneManager.LoadScene ("stage1");
	}

	void ToStage2 ()
	{
		SceneManager.LoadScene ("stage2");
	}
	void ToStage3 ()
	{
		SceneManager.LoadScene ("stage3");
	}
	void Title ()
	{
		SceneManager.LoadScene ("title");
	}
}