using Game.Infrastructure.Data;
using Utils.Observing.SubjectProperties;

namespace Game.Audio
{
  public class AudioData : IData
  {
    public readonly SubjectFloat AudioVolume = new(0.7f, min: 0, max: 1);
  }
}