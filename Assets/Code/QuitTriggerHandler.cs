using UnityEngine;
using UnityEngine.UI;  
using UnityEngine.SceneManagement;  

public class QuitTriggerHandler : MonoBehaviour
{
    public GameObject quitScreenPanel; 
    public Button yesButton;           
    public Button noButton;            

 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            quitScreenPanel.SetActive(true);

            
        }
    }

   
    void Start()
    {
       
        quitScreenPanel.SetActive(false);

        
        yesButton.onClick.AddListener(QuitGame);
        noButton.onClick.AddListener(CancelQuit);
    }

  
    void QuitGame()
    {
        
        Debug.Log("Quitting the game...");
        Application.Quit();

      
    }

    
    void CancelQuit()
    {
       
        quitScreenPanel.SetActive(false);


    }
}
