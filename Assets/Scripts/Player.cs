using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PhysicsObject {

  const float movingSpeed = 15.0f;

  //--------------------------------------------------
  protected override void Start() {
    
  }

  //--------------------------------------------------
  protected override void Update() {
    base.Update();
    if (InputHandler.touchDown) {
      movingDst = InputHandler.touchPosition;

      Vector2 direction = movingDst - position;
      velocity = direction.normalized * movingSpeed;
    }
  }
}
