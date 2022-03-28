 using System.Collections;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class SplashToMenu : MonoBehaviour
 {

    
     void Start()
     {
         StartCoroutine(LoadLevelAfterDelay());
     }
 
     IEnumerator LoadLevelAfterDelay()
     {
         yield return new WaitForSeconds(4);
         SceneManager.LoadScene(1);
     }
 }