using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TimeCount : MonoBehaviour {

  public Canvas canvas;
  Text text;
  float timer = 4 * 60 + 34;
  //float timer = 12;

  // Use this for initialization
  void Start () {
    foreach (Transform child in canvas.transform)
    {
      if (child.name == "Timer")
      {
        text = child.gameObject.GetComponent<Text>();
        text.transform.SetParent(canvas.transform, false);
        text.text = makeText(timer);
      }
    }
  }

  // Update is called once per frame
  void Update () {
    timer -= Time.deltaTime;
    foreach (Transform child in canvas.transform)
    {
      if (child.name == "Timer")
      {
        text = child.gameObject.GetComponent<Text>();
        text.transform.SetParent(canvas.transform, false);
        text.text = makeText(timer);
      }

      if(timer < 0)
      {
        SceneManager.LoadScene("End");
      }
    }

  }

  string makeText(float timer)
  {
    string str = "";
    if((int)timer / 60 == 0)
    {
      if ((int)timer % 60 < 10)
      {
        str = "0分0" + ((int)timer % 60).ToString() + "秒";
      }
      else {
        str = "0分" + ((int)timer % 60).ToString() + "秒";
      }
    }
    else
    {
      if ((int)timer % 60 < 10)
      {
        str = ((int)timer / 60).ToString() + "分0" + ((int)timer % 60).ToString() + "秒";
      }
      else {
        str = ((int)timer / 60).ToString() + "分" + ((int)timer % 60).ToString() + "秒";
      }
    }
    
    return str ;
  }
}
