// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;
using System;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;

namespace XRDE
{
    public class JNUDataExtractor : MonoBehaviour, IDataExtractor
    {
        // To-do
        public void Initialize()
        {
            // To-do
        }

        public void UpdateData()
        {
            // Get JNUData list
            List<string> dataList = DataExtractorManager.Data.JNUData;

            // To-do (example)
            dataList.Add("JNU_stick_grab_valid, <T> to string");
            dataList.Add("JNU_stick_try_number, <T> to string");
            dataList.Add("JNU_stick_try_time, <T> to string");
            dataList.Add("JNU_cover_grab_valid, <T> to string");
            dataList.Add("JNU_cover_try_number, <T> to string");
            dataList.Add("JNU_cover_try_time, <T> to string");
            dataList.Add("JNU_prism_grab_valid, <T> to string");
            dataList.Add("JNU_prism_try_number, <T> to string");
            dataList.Add("JNU_prism_try_time, <T> to string");
        }

        public void Reset()
        {
            Initialize();
        }
    }
}