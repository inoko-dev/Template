using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InnoStudio
{
    public class LobbyAction : GameState
    {
        public GameStateID GameStateID()
        {
            return InnoStudio.GameStateID.Lobby;
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
            Debug.LogError("Lobby");
        }
    }
}
