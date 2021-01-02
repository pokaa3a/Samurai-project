using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tool {

  public const float gameScale = 1.0f;

  //--------------------------------------------------
  public static Vector2 World2Game(Vector2 worldVec2) {
    return worldVec2 * gameScale;
  }

  //--------------------------------------------------
  public static Vector2 World2Game(Vector3 worldVec3) {
    return worldVec3 * gameScale;
  }

  //--------------------------------------------------
  public static float World2Game(float worldVal) {
    return worldVal * gameScale;
  }

  //--------------------------------------------------
  public static Vector2 Game2World(Vector2 gameVec2) {
    return gameVec2 / gameScale;
  }

  //--------------------------------------------------
  public static float Game2World(float gameVal) {
    return gameVal / gameScale;
  }
}
