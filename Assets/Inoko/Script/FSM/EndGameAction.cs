using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InnoStudio 
{
    public class EndGameAction : GameState
    {
        public GameStateID GameStateID()
        {
            return InnoStudio.GameStateID.EndGame;
        }

        public void OnEnter()
        {

        }

        public void OnExit()
        {
        }

        public void OnFixedUpdate()
        {
        }

        public void OnLateUpdate()
        {
        }

        public void OnUpdate()
        {
            Debug.LogError("EndGame");
        }
    }
}