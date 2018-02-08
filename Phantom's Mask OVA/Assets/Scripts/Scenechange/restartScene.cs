using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class restartScene : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick(PointerEventData pointerEventData)
	{
		Scene thisscene = SceneManager.GetActiveScene ();

		if (pointerEventData.button == PointerEventData.InputButton.Left) {
			SceneManager.LoadScene (thisscene.name);
		}
	}
}
