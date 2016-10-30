using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Scene : MonoBehaviour
{
  public void start()
  {
    SceneManager.LoadScene("Main");
  }

  public void introduction()
  {
    SceneManager.LoadScene("Introduction");
  }

  public void Title()
  {
    SceneManager.LoadScene("Title");
  }

  public void End()
  {
    SceneManager.LoadScene("End");
  }

  public void Tweet()
  {
    string message = "4分33秒を演奏しました (短縮URL) #nikonamakudou";
    Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
  }
}