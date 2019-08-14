using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanavasController : MonoBehaviour
{
    public Image ImageToDisplay;
    
    public void DisplayBadEnding()
    {
        this.ImageToDisplay.gameObject.SetActive(true);
    }

    private IEnumerator changeScene()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("EndScreen");
    }
}
