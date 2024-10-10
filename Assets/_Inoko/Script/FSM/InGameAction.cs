using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InnoStudio
{
    public class InGameAction : GameState
    {
        public GameStateID GameStateID()
        {
            return InnoStudio.GameStateID.InGame;
        }

        public void OnEnter()
        {
            Debug.Log("OnInGame");
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
        }
    }
}