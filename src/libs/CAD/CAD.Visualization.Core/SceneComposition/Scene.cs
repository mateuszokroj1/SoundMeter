namespace SoundMeter.Framework.CAD.Visualization.SceneComposition;

public interface IScene : ISceneComponent
{
    ISceneComposite Root { get; }
}