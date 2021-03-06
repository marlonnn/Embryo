﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmbryoExpress.ExtensionMethods;

namespace EmbryoExpress.Instrument
{
    public class Range
    {
        private int minValue;
        public int MinValue
        {
            get { return this.minValue; }
            set { this.minValue = value; }
        }

        private int maxValue;
        public int MaxValue
        {
            get { return this.maxValue; }
            set { this.maxValue = value; }
        }

        public Range (int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
    }

    [LocalizedResource(typeof(Res.Instrument))]
    public enum Calibration
    {
        [LocalizedDescription("StrUncalibrated")]
        Uncalibrated,
        [LocalizedDescription("StrCalibrated")]
        Calibrated
    }

    [LocalizedResource(typeof(Res.Instrument))]
    public enum Cleaning
    {
        [LocalizedDescription("StrUnClean")]
        UnClean,
        [LocalizedDescription("StrCleaned")]
        Cleaned
    }

    [LocalizedResource(typeof(Res.Instrument))]
    public enum Maintenance
    {
        [LocalizedDescription("StrUnMaintained")]
        UnMaintained,
        [LocalizedDescription("StrMaintained")]
        Maintained
    }

    [LocalizedResource(typeof(Res.Instrument))]
    public enum OperationType
    {
        [LocalizedDescription("StrUnKnown")]
        UnKnown,
        [LocalizedDescription("StrPickingEgg")]
        PickingEgg,
        [LocalizedDescription("StrDegranulation")]
        Degranulation,
        [LocalizedDescription("StrSelectionEmbryo")]
        SelectionEmbryo,
        [LocalizedDescription("StrTransferEmbryo")]
        TransferEmbryo,
        [LocalizedDescription("StrFrozenEmbryo")]
        FrozenEmbryo,
        [LocalizedDescription("StrThawedEmbryo")]
        ThawedEmbryo
    }

    [LocalizedResource(typeof(Res.Instrument))]
    public enum OperationResult
    {
        [LocalizedDescription("StrUnKnown")]
        UnKnown,
        [LocalizedDescription("StrFailure")]
        Failure,
        [LocalizedDescription("StrSuccess")]
        Success
    }

    [LocalizedResource(typeof(Res.Instrument))]
    public enum Status
    {
        [LocalizedDescription("StrNotStarted")]
        NotStarted,
        [LocalizedDescription("StrCompleted")]
        Completed,
        [LocalizedDescription("StrInProgress")]
        InProgress,
        [LocalizedDescription("StrDeferred")]
        Deferred
    }

    public class BaseInstrument
    {
        private Cleaning cleaning = Cleaning.UnClean;
        public Cleaning Cleaning
        {
            get { return this.cleaning; }
            set { this.cleaning = value; }
        }

        private Calibration calibration = Calibration.Uncalibrated;
        public Calibration Calibration
        {
            get { return this.calibration; }
            set { this.calibration = value; }
        }

        private Maintenance maintenance = Maintenance.UnMaintained;
        public Maintenance Maintenance
        {
            get { return this.maintenance; }
            set { this.maintenance = value; }
        }

        private string usageRecord;
        public string UsageRecord
        {
            get { return this.usageRecord; }
            set { this.usageRecord = value; }
        }
    }
}
