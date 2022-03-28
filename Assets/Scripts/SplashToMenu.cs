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
         yield return new WaitForSeconds(3);
         SceneManager.LoadScene(1);
     }
 }