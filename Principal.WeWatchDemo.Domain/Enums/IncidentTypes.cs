using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Principal.WeWatchDemo.Domain.ModelDtos.Enums
{
    public enum IncidentTypes
    {
        [Description("Car Accident")] CarAccident = 0,
        [Description("Plane Crash")] PlaneCrash = 1,
        [Description("Assault")] Assault = 2,
        [Description("Stalking")] Stalking = 3
    }
}
