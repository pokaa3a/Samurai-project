using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : State {
  
  public enum STATE {
    IDLE, MOVE
  };
  
  public STATE name;
  protected Player player;

  //--------------------------------------------------
  public PlayerState(Player player) {
    this.player = player;
  }
}
