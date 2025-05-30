// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class ComputeRecurrenceSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeRecurrenceSchedule,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeRecurrenceScheduleInternal
    {

        /// <summary>Backing field for <see cref="Hour" /> property.</summary>
        private int[] _hour;

        /// <summary>[Required] List of hours for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int[] Hour { get => this._hour; set => this._hour = value; }

        /// <summary>Backing field for <see cref="Minute" /> property.</summary>
        private int[] _minute;

        /// <summary>[Required] List of minutes for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int[] Minute { get => this._minute; set => this._minute = value; }

        /// <summary>Backing field for <see cref="MonthDay" /> property.</summary>
        private int[] _monthDay;

        /// <summary>List of month days for the schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int[] MonthDay { get => this._monthDay; set => this._monthDay = value; }

        /// <summary>Backing field for <see cref="WeekDay" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeWeekDay[] _weekDay;

        /// <summary>List of days for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeWeekDay[] WeekDay { get => this._weekDay; set => this._weekDay = value; }

        /// <summary>Creates an new <see cref="ComputeRecurrenceSchedule" /> instance.</summary>
        public ComputeRecurrenceSchedule()
        {

        }
    }
    public partial interface IComputeRecurrenceSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>[Required] List of hours for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] List of hours for the schedule.",
        SerializedName = @"hours",
        PossibleTypes = new [] { typeof(int) })]
        int[] Hour { get; set; }
        /// <summary>[Required] List of minutes for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] List of minutes for the schedule.",
        SerializedName = @"minutes",
        PossibleTypes = new [] { typeof(int) })]
        int[] Minute { get; set; }
        /// <summary>List of month days for the schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of month days for the schedule",
        SerializedName = @"monthDays",
        PossibleTypes = new [] { typeof(int) })]
        int[] MonthDay { get; set; }
        /// <summary>List of days for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of days for the schedule.",
        SerializedName = @"weekDays",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeWeekDay) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeWeekDay[] WeekDay { get; set; }

    }
    internal partial interface IComputeRecurrenceScheduleInternal

    {
        /// <summary>[Required] List of hours for the schedule.</summary>
        int[] Hour { get; set; }
        /// <summary>[Required] List of minutes for the schedule.</summary>
        int[] Minute { get; set; }
        /// <summary>List of month days for the schedule</summary>
        int[] MonthDay { get; set; }
        /// <summary>List of days for the schedule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeWeekDay[] WeekDay { get; set; }

    }
}