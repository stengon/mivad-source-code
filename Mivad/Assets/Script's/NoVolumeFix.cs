﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoVolumeFix : MonoBehaviour
{

  void Start()
  {
    Time.timeScale = 1f;
    AudioListener.pause = false;
  }
  
}
