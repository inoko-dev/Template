using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InnoStudio
{
    public class LoadingManager : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        private void Start()
        {
            LoadSceneMasterLevel();
        }

        void LoadSceneMasterLevel()
        {

        }
    }
}
