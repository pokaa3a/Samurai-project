using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
  
  // Only one frame should be activated
  public static bool touchDown = false;
  public static Vector2 touchPosition = Vector2.zero;

  //--------------------------------------------------
  void Update() {
    if (Input.GetMouseButton(0)) {
      touchDown = true;
      touchPosition = Tool.World2Game(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    } else {
      touchDown = false;
    }
  }
}
