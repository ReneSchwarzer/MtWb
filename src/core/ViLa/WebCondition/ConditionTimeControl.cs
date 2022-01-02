﻿using ViLa.Model;
using WebExpress.WebCondition;
using WebExpress.Message;

namespace ViLa.WebCondition
{
    public class ConditionTimeControl : ICondition
    {
        /// <summary>
        /// Die Bedingung
        /// </summary>
        /// <param name="request">Die Anfrage</param>
        /// <returns>true wenn die Bedingung erfüllt ist, false sonst</returns>
        public bool Fulfillment(Request request)
        {
            return ViewModel.Instance.Settings.Mode == Mode.TimeControlled;
        }
    }
}