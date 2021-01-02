using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class State {
  public enum EVENT {
    ENTER, UPDATE, EXIT
  };
  protected EVENT stage = EVENT.ENTER;
  protected State nextState;
  public State() {}

  //--------------------------------------------------
  // Do things that should be done before entering this state
  public virtual void Enter() {
    stage = EVENT.UPDATE;
  }

  //--------------------------------------------------
  // Do things during this state
  public virtual void Update() {
    stage = EVENT.UPDATE;
  }

  //--------------------------------------------------
  // Do things before leaving this state
  public virtual void Exit() {
    stage = EVENT.EXIT;
  }

  //--------------------------------------------------
  // Process() will be called every frame (Update function)
  public State Process() {
    switch (stage) {
      case EVENT.ENTER:
        Enter();
        break;
      case EVENT.UPDATE:
        Update();
        break;
      case EVENT.EXIT:
        Exit();
        return nextState;
      default:
        Assert.IsTrue(false);
        break;
    }
    return this;
  }

  //--------------------------------------------------
  public void ChangeState(State newState) {
    nextState = newState;
    stage = EVENT.EXIT;
  }
}
