using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour {

  const float minDistance = 0.001f;
  protected Vector2 velocity = Vector2.zero;
  protected Vector2 movingDst = Vector2.zero;   // moving destination

  //--------------------------------------------------
  public Vector2 position {
    get {
      return Tool.World2Game(gameObject.transform.position);
    }
    set {
      gameObject.transform.position = Tool.Game2World(value);
    }
  }

  //--------------------------------------------------
  public Quaternion rotation {
    get {
      return gameObject.transform.rotation;
    }
    set {
      gameObject.transform.rotation = value;
    }
  }

  //--------------------------------------------------
  public Vector2 forward {
    get {
      return new Vector2(Mathf.Cos(gameObject.transform.eulerAngles.z * Mathf.Deg2Rad),
                         Mathf.Sin(gameObject.transform.eulerAngles.z * Mathf.Deg2Rad));
    }
  }

  //--------------------------------------------------
  protected virtual void Start() {}

  //--------------------------------------------------
  protected virtual void Update() {
    if (Vector2.Distance(position, movingDst) < minDistance) {
      velocity = Vector2.zero;
    }
  }

  //--------------------------------------------------
  protected virtual void FixedUpdate() {
    Move();
  }

  //--------------------------------------------------
  protected void Move() {
    float step = velocity.magnitude * Time.deltaTime;
    if (Vector2.Distance(position, movingDst) < step) {
      step = Vector2.Distance(position, movingDst);
    }
    position += velocity.normalized * step;
  }
}
