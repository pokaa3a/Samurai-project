using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMove : PlayerState {

  //--------------------------------------------------
  public PlayerStateMove(Player player) : base(player) {
    name = PlayerState.STATE.MOVE;
    nextState = new PlayerStateIdle(player);
  }

  //--------------------------------------------------
  public override void Update() {
    
  }
}
