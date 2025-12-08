using UnityEngine;

public class QuitApp : MonoBehaviour
{
    //this script will quit the application
        public void Quit()
    {
        Application.Quit();
        Debug.Log("Application has quit");
    }
}
