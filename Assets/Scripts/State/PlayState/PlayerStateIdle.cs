using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateIdle : PlayerState {

  //--------------------------------------------------
  public PlayerStateIdle(Player player) : base(player) {
    name = PlayerState.STATE.IDLE;
    nextState = new PlayerStateIdle(player);
  }
}
