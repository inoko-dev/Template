using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InnoStudio
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private UIController uiController;
        [SerializeField] private SoundManager soundManager;
        [SerializeField] private FeatureController featureController;
        [SerializeField] private EventGameController eventGameController;
        public UIController UIController => uiController;
        public SoundManager SoundManager => soundManager;
        public FeatureController FeatureController => featureController;
        public EventGameController EventGameController => eventGameController;

        private void Awake()
        {
            
        }

        private void Start()
        {
            
        }

        public void Update()
        {
            
        }

        public void FixedUpdate()
        {
            
        }

        public void LateUpdate()
        {
            
        }
    }
}


