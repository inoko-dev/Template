using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InnoStudio
{
    public class PlayerDataManager : MonoBehaviour
    {
        public static PlayerDataManager Instance {  get; set; }

        private void Awake()
        {
            Instance = this;
        }
    }
}
