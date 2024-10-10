using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InnoStudio
{
    public class UILobby : UICanvas
    {
        [FoldoutGroup("Button")]
        [SerializeField] private Button btnClose;
        [FoldoutGroup("Button")]
        [SerializeField] private Button btnPlay;

        public void Init()
        {
            btnClose.onClick.AddListener(OnBtnClose);
            btnPlay.onClick.AddListener(OnBtnPlay);
        }

        public override void OnBtnClose()
        {
            base.OnBtnClose();
        }

        public void OnBtnPlay()
        {
            GameManager.Instance.GameFSMController.ChangeState(GameStateID.InGame);
        }
    }
}