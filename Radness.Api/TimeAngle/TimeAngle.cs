using System.ComponentModel.DataAnnotations;

namespace Radness.Api.TimeAngle;

public class TimeAngle
{
    [Required]
    public DateTime Time { get; set; }
}