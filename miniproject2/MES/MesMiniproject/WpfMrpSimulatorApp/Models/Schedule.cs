using System;
using System.Collections.Generic;

namespace WpfMrpSimulatorApp.Models;

public partial class Schedule
{
    public int SchIdx { get; set; }

    /// <summary>
    /// 공장코드
    /// </summary>
    public string PlantCode { get; set; } = null!;

    public DateOnly SchDate { get; set; }

    /// <summary>
    /// 로드타임(초)
    /// </summary>
    public int LoadTime { get; set; }

    public TimeOnly? SchStartTime { get; set; }

    public TimeOnly? SchEndTime { get; set; }

    /// <summary>
    /// 생산설비 ID
    /// </summary>
    public string? SchFacilityId { get; set; }

    /// <summary>
    /// 계획목표수량
    /// </summary>
    public int? SchAmount { get; set; }

    public DateTime? RegDt { get; set; }

    public DateTime? ModDt { get; set; }

    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();
}
