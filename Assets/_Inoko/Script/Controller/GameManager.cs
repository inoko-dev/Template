using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InnoStudio
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; set; }

        [FoldoutGroup("Controller")]
        [SerializeField] private UIController uiController;
        [FoldoutGroup("Controller")]
        [SerializeField] private SoundManager soundManager;
        [FoldoutGroup("Controller")]
        [SerializeField] private FeatureController featureController;
        [FoldoutGroup("Controller")]
        [SerializeField] private EventGameController eventGameController;

        public UIController UIController => uiController;
        public SoundManager SoundManager => soundManager;
        public FeatureController FeatureController => featureController;
        public EventGameController EventGameController => eventGameController;
        public PlayerDataManager PlayerDataManager => PlayerDataManager.Instance;

        public GameFSMController GameFSMController;

        private void Awake()
        {
            GameFSMController = new GameFSMController();
            GameFSMController.AddState(new LobbyAction());
            GameFSMController.AddState(new InGameAction());
            GameFSMController.AddState(new EndGameAction());
            GameFSMController.ChangeState(GameStateID.Lobby);
        }

        private void Start()
        {
            UIController.Init();
            DataLevel dataLevel = new DataLevel();
            PlayerDataManager.SetDataLevel(dataLevel);
        }

        public void Update()
        {
            GameFSMController.OnUpdate();
        }

        public void FixedUpdate()
        {
            GameFSMController.OnFixedUpdate();
        }

        public void LateUpdate()
        {
            GameFSMController.OnLateUpdate();
        }
    }
}


